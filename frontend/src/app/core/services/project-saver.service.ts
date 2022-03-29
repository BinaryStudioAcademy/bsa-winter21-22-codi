import { Injectable, OnDestroy, OnInit } from '@angular/core';
import { FileStateWrapper } from "@core/models/file/file-state-wrapper";
import { FileService } from "@core/services/file.service";
import { UpdateFile } from "@core/models/file/update-file";
import { Project } from "@core/models/project/project";
import { Subject, takeUntil } from "rxjs";
import { ProjectService } from "@core/services/project.service";

@Injectable({
    providedIn: 'root'
})
export class ProjectSaverService implements OnDestroy {
    private newTitle: string;
    private isProjectInfoChanged: boolean = false;
    private unsubscribe$ = new Subject<void>();

    projectInfo: Project;
    loadedFiles: FileStateWrapper[] = [];

    constructor(
        private fileService: FileService,
        private projectService: ProjectService
    ) { }

    ngOnDestroy() {
        this.unsubscribe$.next();
        this.unsubscribe$.complete();
    }

    setProjectTitleIfChanged(title: string) {
        if(this.projectInfo?.title !== title) {
            this.isProjectInfoChanged = true;
            this.newTitle = title;
        }
        else {
            this.isProjectInfoChanged = false;
        }
    }

    isProjectChanged() {
        return this.anyFilesChanged() || this.isProjectInfoChanged;
    }

    saveChanges() {
        if(this.isProjectInfoChanged) {
            this.saveChangedProjectInfo();
        }
        if(this.anyFilesChanged()) {
            this.saveChangedFiles();
        }
    }

    discardChanges() {
        this.loadedFiles = [];
        this.newTitle = undefined!;
    }

    private saveChangedProjectInfo() {
        this.projectService
            .updateProject(this.projectInfo.id,
                {
                    title: this.newTitle,
                    description: this.projectInfo.description,
                    isPublic: this.projectInfo.isPublic })
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe((proj) =>{
                this.projectInfo = proj;
                this.isProjectInfoChanged = false;
            })
    }

    private saveChangedFiles() {
        let changedFiles = this.loadedFiles.filter(w => w.isChanged)
            .map(w => {
                return {id: w.file.id, name: w.file.name, content: w.file.content} as UpdateFile
            });
        this.fileService.updateFiles(changedFiles)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(() => {
                this.setUnChangedState();
            });
    }

    private anyFilesChanged() {
        return this.loadedFiles.some(w => w.isChanged);
    }

    private setUnChangedState() {
        this.loadedFiles.forEach(w => w.isChanged = false);
    }
}
