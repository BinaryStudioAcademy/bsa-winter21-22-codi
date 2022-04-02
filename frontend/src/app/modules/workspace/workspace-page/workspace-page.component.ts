import { AfterViewInit, Component, OnDestroy, OnInit, ViewChild } from '@angular/core';
import { BaseComponent } from "@core/base/base.component";
import { ProjectStructureService } from "@core/services/project-structure.service";
import { ActivatedRoute, Router } from "@angular/router";
import { Observable, Observer, of, Subject, takeUntil } from "rxjs";
import { ProjectStructure } from "@core/models/structure/project-structure";
import { FsNodeType } from "@core/enums/fs-node-type";
import { FileService } from "@core/services/file.service";
import { File } from "@core/models/file/file";
import { FsNode } from "@core/models/structure/fs-node";
import { GetLanguageByFileName } from "@shared/helpers/language-helper";
import { ProjectService } from "@core/services/project.service";
import { EditorOptions } from "@core/models/editor-options";
import { FileStateWrapper } from "@core/models/file/file-state-wrapper";
import { ComponentCanDeactivate } from "@core/guards/save-before-leave.guard";
import { ConfirmationDialogService } from "@core/services/confirmation-dialog.service";
import { ConfirmationDialogResult } from "@core/models/confirmation-dialog/confirmation-dialog-result";
import { NotificationService } from "@core/services/notification.service";
import { ProjectSaverService } from "@core/services/project-saver.service";
import { BuildHubService } from '@core/hubs/build-hub.service';
import { FunctionsUsingCSI, NgTerminal } from 'ng-terminal';
import { ConsoleService } from '@core/services/console.service';

@Component({
    selector: 'app-workspace-page',
    templateUrl: './workspace-page.component.html',
    styleUrls: ['./workspace-page.component.sass']
})
export class WorkspacePageComponent extends BaseComponent implements OnInit, OnDestroy, AfterViewInit, ComponentCanDeactivate {
    confirmationOnLeavePage$: Observable<boolean>;
    editorOptions: EditorOptions;

    userCanEdit: boolean = false;
    projectId: number;
    projectStructure: ProjectStructure;
    fsNodeType = FsNodeType;
    openedFiles: File[] = [];
    selectedNode: FsNode;
    selectedFile: File;
    initialCode: string;
    currentCode: string;
    input: string;

    codeChanged: Subject<string> = new Subject<string>();

    @ViewChild('term', { static: true }) child: NgTerminal;

    constructor(
        private route: ActivatedRoute,
        private router: Router,
        private projectService: ProjectService,
        private projectStructureService: ProjectStructureService,
        private confirmationDialogService: ConfirmationDialogService,
        private fileService: FileService,
        private projectSaverService: ProjectSaverService,
        private notificationService: NotificationService,
        private buildHub: BuildHubService,
        private consoleService: ConsoleService,
    ) {
        super();
    }

    override ngOnDestroy() {
        this.buildHub.stop();
        super.ngOnDestroy();
    }


    ngAfterViewInit() {
        this.child.write(FunctionsUsingCSI.cursorColumn(1));

        this.child.keyEventInput.subscribe(e => {
            console.log('keyboard event:' + e.domEvent.keyCode + ', ' + e.key);

            const ev = e.domEvent;
            const printable = !ev.altKey && !ev.ctrlKey && !ev.metaKey;

            if (ev.keyCode === 13) {
                this.sendInput(this.input);
                this.input = "";
            } else if (ev.keyCode === 8) {
                if (this.child.underlying.buffer.active.cursorX > 2) {
                    this.child.write('\b \b');
                }
            } else if (printable) {
                this.child.write(e.key);
                this.input = this.input + e.key;
            }
        })

    }

    sendInput(input: string) {
        this.projectService
            .inputProject(this.projectSaverService.projectInfo.id, input)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(() => {})
    }

    async ngOnInit() {
        this.setGreeting();
        this.setUpEditorForCurrentFile();
        this.route.params.pipe(
            takeUntil(this.unsubscribe$)
        ).subscribe(() => {
            this.projectId = this.route.snapshot.params['id'];
            this.getProjectStructure();
            this.setIsUserEditable();
        });

        this.confirmationOnLeavePage();

        this.codeChanged
            .subscribe((code) => {
                this.setFileChanges(code)
            })

        this.consoleService.start$.subscribe(() => {
            setTimeout(() => {
                this.child.write("Hello World!");

                this.child.write('\n' + FunctionsUsingCSI.cursorColumn(1));
                let secs = 0;
                setInterval(() => {
                    secs++;
                    this.child.write("Seconds: " + secs);
                    this.child.write('\n' + FunctionsUsingCSI.cursorColumn(1));
                }, 1000)
            }, 4000)
        })
    }

    onSelectedNode(event: any) {
        this.selectedNode = event.node.data;
    }

    openFileFromTab(file: File) {
        if (this.selectedFile !== file) {
            this.setSelectedFile(file);
            this.setUpEditorForCurrentFile();
        }
    }

    closeFile(file: File) {
        this.setNextOpenedFile(file);
        this.setUpEditorForCurrentFile();
        this.openedFiles = this.openedFiles.filter(f => f.id !== file.id);
    }

    openRequestedFile(node: FsNode) {
        if (node.type === FsNodeType.file && this.selectedFile?.id !== node.fileId) {
            let localFile = this.openedFiles.find(f => f.id === node.fileId) ??
                this.projectSaverService.loadedFiles.find(f => f.file.id === node.fileId)?.file;
            if (localFile) {
                this.setLocalFile(localFile);
                this.setUpEditorForCurrentFile();
            }
            else {
                this.setRemoteFile(node.fileId!).subscribe((remoteFile) => {
                    let fileStateWrapper = {
                        file: remoteFile,
                        isChanged: false
                    } as FileStateWrapper;
                    this.projectSaverService.loadedFiles.push(fileStateWrapper);
                    this.openedFiles.push(remoteFile);
                    this.setSelectedFile(remoteFile);
                    this.setUpEditorForCurrentFile();
                });
            }
        }
    }

    canDeactivate(): boolean | Observable<boolean> {
        return !this.projectSaverService.isProjectChanged() ? of(true) : this.confirmationOnLeavePage$
    }

    private setIsUserEditable() {
        this.projectService.isUserEditable(this.projectId)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((res) => {
                this.userCanEdit = res;
            });
    }

    private confirmationOnLeavePage() {
        this.confirmationOnLeavePage$ = Observable.create((observer: Observer<boolean>) => {
            this.openNotSavedFilesWarning()
                .subscribe((res) => {
                    if (res === ConfirmationDialogResult.Confirm) {
                        this.projectSaverService.saveChanges();
                        this.notificationService.showSuccessMessage('Project changes saved', 'Success');
                        observer.next(true);
                    }
                    else if (res === ConfirmationDialogResult.Cancel) {
                        this.projectSaverService.discardChanges();
                        observer.next(true);
                    }
                });
        });
    }

    private openNotSavedFilesWarning() {
        return this.confirmationDialogService
            .openConfirmationDialog(
                `Unsaved changes`,
                `It seems that you have unsaved local changes.
                Do you want to save them before close?`,
                {
                    centered: true,
                    confirmButtonText: 'Save',
                    cancelButtonText: 'Discard'
                }
            )
    }

    private setFileChanges(currentCode: string) {
        this.selectedFile.content = currentCode;
        this.initialCode !== currentCode
            ? this.setFileState(this.selectedFile, true)
            : this.setFileState(this.selectedFile, false);
    }

    private setFileState(file: File, isChanged: boolean) {
        let fileWrapper = this.projectSaverService.loadedFiles.find(w => w.file === file);
        if (fileWrapper) {
            fileWrapper.isChanged = isChanged;
        }
    }

    private setSelectedFile(file: File) {
        this.selectedFile = file;
        this.currentCode = this.initialCode = file.content;
    }

    private setUpEditorForCurrentFile() {
        let lang = GetLanguageByFileName(this.selectedFile?.name);
        this.editorOptions = {
            theme: 'vs-dark',
            scrollBeyondLastLine: false,
            language: lang,
            readOnly: !this.userCanEdit
        };
    }

    private setNextOpenedFile(file: File) {
        if (this.selectedFile.id === file.id) {
            let openedFileIndex = this.openedFiles.indexOf(file);
            if (openedFileIndex - 1 < 0 && openedFileIndex + 1 < this.openedFiles.length) {
                this.setSelectedFile(this.openedFiles[openedFileIndex + 1]);
            }
            else if (openedFileIndex - 1 >= 0) {
                this.setSelectedFile(this.openedFiles[openedFileIndex - 1]);
            }
            else {
                this.setGreeting();
            }
        }
    }

    private setGreeting() {
        this.selectedFile = undefined!;
        this.currentCode = "Select a file to start coding";
    }

    private setLocalFile(localFile: File) {
        this.setSelectedFile(localFile);
        if (!this.isOpenedFile(localFile.id)) {
            this.openedFiles.push(localFile);
        }
    }

    private setRemoteFile(fileId: string) {
        return this.fileService
            .getFile(fileId)
            .pipe(takeUntil(this.unsubscribe$))
    }

    private isOpenedFile(fileId: string) {
        return this.openedFiles.some(f => f.id === fileId);
    }

    private getProjectStructure() {
        this.projectStructureService.getProjectStructure(this.projectId)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((res) => {
                this.projectStructure = res;
            },
            (error) => {
                this.router.navigate(['not-found']);
            });
    }

    onCodeChange(event: string) {
        if (this.selectedFile && this.selectedFile.content !== this.currentCode) {
            this.codeChanged.next(event);
        }
    }
}
