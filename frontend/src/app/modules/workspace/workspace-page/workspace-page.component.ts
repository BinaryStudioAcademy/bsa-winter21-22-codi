import { Component, OnInit } from '@angular/core';
import { BaseComponent } from "@core/base/base.component";
import { ProjectStructureService } from "@core/services/project-structure.service";
import { ActivatedRoute } from "@angular/router";
import { takeUntil } from "rxjs";
import { ProjectStructure } from "@core/models/structure/project-structure";
import { FsNodeType } from "@core/enums/fs-node-type";
import { FileService } from "@core/services/file.service";
import { File } from "@core/models/file/file";
import { FsNode } from "@core/models/structure/fs-node";
import { GetLanguageByExtension } from "@shared/helpers/language-helper";
import { Project } from "@core/models/project/project";
import { ProjectService } from "@core/services/project.service";

@Component({
    selector: 'app-workspace-page',
    templateUrl: './workspace-page.component.html',
    styleUrls: ['./workspace-page.component.sass']
})
export class WorkspacePageComponent extends BaseComponent implements OnInit{
    editorOptions: any;

    projectId: number;
    projectInfo: Project;
    projectStructure: ProjectStructure;
    fsNodeType = FsNodeType;
    loadedFiles: File[] = [];
    openedFiles: File[] = [];
    selectedNode: FsNode;
    selectedFile: File;

    constructor(
        private route: ActivatedRoute,
        private projectService: ProjectService,
        private projectStructureService: ProjectStructureService,
        private fileService: FileService
    ) {
        super();
    }

    ngOnInit() {
        this.setGreetingFile();
        this.setUpEditorForCurrentFile();
        this.route.params.pipe(
            takeUntil(this.unsubscribe$)
        ).subscribe(() => {
            this.projectId = this.route.snapshot.params['id'];
            this.getProjectStructure();
        });
    }

    onSelectedNode(event: any) {
        this.selectedNode = event.node.data;
    }

    openFileFromTab(file: File) {
        if(this.selectedFile !== file) {
            this.selectedFile = file;
            this.setUpEditorForCurrentFile();
        }
    }

    closeFile(file: File) {
        this.setNextOpenedFile(file);
        this.setUpEditorForCurrentFile();
        this.openedFiles = this.openedFiles.filter(f => f.id !== file.id);
    }

    openRequestedFile(node: FsNode) {
        if(node.type === FsNodeType.file && this.selectedFile.id !== node.fileId) {
            let localFile = this.openedFiles.find(f => f.id === node.fileId) ?? this.loadedFiles.find(f => f.id === node.fileId);
            if(localFile) {
                this.setLocalFile(localFile);
                this.setUpEditorForCurrentFile();
            }
            else{
                this.setRemoteFile(node.fileId!).subscribe((remoteFile) => {
                    this.loadedFiles.push(remoteFile);
                    this.openedFiles.push(remoteFile);
                    this.selectedFile = remoteFile;
                    this.setUpEditorForCurrentFile();
                });
            }
        }
    }

    private setUpEditorForCurrentFile() {
        let lang = GetLanguageByExtension(this.selectedFile?.name);
        this.editorOptions = {
            theme: 'vs-dark',
            scrollBeyondLastLine: false,
            language: lang,
            automaticLayout: true
        }
    }

    private setNextOpenedFile(file: File) {
        if(this.selectedFile.id === file.id) {
            let openedFileIndex = this.openedFiles.indexOf(file);
            if(openedFileIndex - 1 < 0 && openedFileIndex + 1 < this.openedFiles.length) {
                this.selectedFile = this.openedFiles[openedFileIndex + 1];
            }
            else if(openedFileIndex - 1 >= 0) {
                this.selectedFile = this.openedFiles[openedFileIndex - 1];
            }
            else {
                this.setGreetingFile();
            }
        }
    }

    private setGreetingFile() {
        this.selectedFile = {
            content: "Select a file to start coding"
        } as File
    }

    private setLocalFile(localFile: File) {
        this.selectedFile = localFile;
        if(!this.isOpenedFile(localFile.id)) {
            this.openedFiles.push(localFile);
        }
    }

    private setRemoteFile(fileId: string) {
        return this.fileService
            .getFile(fileId)
            .pipe(takeUntil(this.unsubscribe$))
    }

    private isOpenedFile(fileId: string) {
        let file = this.openedFiles.find(f => f.id === fileId);
        return file === undefined ? false : true;
    }

    private getProjectStructure() {
        this.projectStructureService.getProjectStructure(this.projectId)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((res) => {
                this.projectStructure = res;
            })
    }
}
