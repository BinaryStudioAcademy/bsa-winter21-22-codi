import { Component, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { BaseComponent } from '@core/base/base.component';
import { CreateApp } from '@core/models/app/create-app';
import { ProjectName } from '@core/models/project/project-name';
import { TagName } from '@core/models/tag/tag-name';
import { AppService } from '@core/services/app.service';
import { NotificationService } from '@core/services/notification.service';
import { ProjectService } from '@core/services/project.service';
import { TagService } from '@core/services/tag.service';
import { NgbActiveModal, NgbTypeahead, NgbTypeaheadSelectItemEvent } from '@ng-bootstrap/ng-bootstrap';
import { debounceTime, distinctUntilChanged, filter, map, merge, Observable, OperatorFunction, Subject, takeUntil } from 'rxjs';

@Component({
    templateUrl: './publish-app-dialog.component.html',
    styleUrls: ['./publish-app-dialog.component.sass'],
})
export class PublishAppDialogComponent extends BaseComponent implements OnInit {

    @ViewChild('projectInstance', { static: true }) projectInstance: NgbTypeahead;
    projectsFocus$ = new Subject<string>();
    projectsClick$ = new Subject<string>();

    @ViewChild('tagsInstance', { static: true }) tagsInstance: NgbTypeahead;
    tagsFocus$ = new Subject<string>();
    tagsClick$ = new Subject<string>();

    userProjects: ProjectName[] = []
    tags: TagName[] = []
    selectedTags: TagName[] = []
    imageFile: File;
    forImage: string;
    previewImage: string;

    form: FormGroup;

    constructor(public modal: NgbActiveModal,
        private notificationService: NotificationService,
        private projectService: ProjectService,
        private appService: AppService,
        private tagService: TagService) {
        super();
    }

    ngOnInit(): void {
        this.loadProjects();
        this.loadTags();

        this.form = new FormGroup({
            project: new FormControl('', [Validators.required]),
            image: new FormControl(null),
        });
    }

    loadProjects() {
        this.projectService
            .getCurrentUserProjectNames()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (resp) => {
                    this.userProjects = resp ?? [];
                },
                error: (error) => {
                    this.notificationService.showErrorMessage(error.message, "Error")
                }

            })
    }

    loadTags() {
        this.tagService
            .getAllTags()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (resp) => {
                    this.tags = resp ?? [];
                },
                error: (error) => {
                    this.notificationService.showErrorMessage(error.message, "Error")
                }

            })
    }

    projectInputFormatter = (project: { title: string }) => project.title;

    searchProjects: OperatorFunction<string, readonly ProjectName[]> = (text$: Observable<string>) => {
        const debouncedText$ = text$.pipe(debounceTime(200), distinctUntilChanged());
        const clicksWithClosedPopup$ = this.projectsClick$.pipe(filter(() => !this.projectInstance.isPopupOpen()));
        return merge(debouncedText$, this.projectsFocus$, clicksWithClosedPopup$).pipe(
            map(term => (term === ''
                ? this.userProjects
                : this.userProjects.filter(p => p.title.toLowerCase().indexOf(term.toLowerCase()) > -1)).slice(0, 25))
        );
    }

    tagFormatter = (tag: { name: string }) => tag.name;

    searchTags: OperatorFunction<string, readonly TagName[]> = (text$: Observable<string>) => {
        const debouncedText$ = text$.pipe(debounceTime(200), distinctUntilChanged());
        const clicksWithClosedPopup$ = this.tagsClick$.pipe(filter(() => !this.tagsInstance.isPopupOpen()));
        return merge(debouncedText$, this.tagsFocus$, clicksWithClosedPopup$).pipe(
            map(term => (term === ''
                ? this.tags
                : this.tags.filter(p => p.name.toLowerCase().indexOf(term.toLowerCase()) > -1)).slice(0, 25))
        );
    }

    selectTag(event: NgbTypeaheadSelectItemEvent<TagName>){
        if(!this.selectedTags.some(t => t.id === event.item.id)){
            this.selectedTags.push(event.item);
        }
        this.tagsInstance.writeValue('');
        event.preventDefault();
    }

    deleteTag(tag: TagName){
        this.selectedTags = this.selectedTags.filter(t => t.id !== tag.id);
    }

    publishApp() {
        let newApp = this.form.value as CreateApp;
        newApp.tags = this.selectedTags.map(t => t.id);
        newApp.projectId = this.form.value.project.id;
        newApp.image = this.forImage;

        this.appService.createApp(newApp)
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe({
                next: (resp) => {
                    this.modal.close(resp)
                    this.notificationService.showSuccessMessage(`App "${resp.name}" successfully published`, 'Success')
                },
                error: (error) => {
                    this.modal.close()
                    this.notificationService.showErrorMessage(error.message, 'Error')
                }
            });
    }

    closeDialog() {
        this.modal.close();
    }

    handleFileInput(target: any) {
        this.imageFile = target.files[0];

        if (!this.imageFile) {
            target.value = '';
            return;
        }

        if (this.imageFile.size / 1000000 > 5) {
            this.notificationService.showErrorMessage(`Image can't be heavier than ~5MB`);
            target.value = '';
            return;
        }

        const reader = new FileReader();
        reader.addEventListener('load', () => ( this.previewImage = reader.result as string));
        reader.readAsDataURL(this.imageFile);
        reader.onloadend = () => {
            this.forImage = reader.result as string;
        };
    }

    removeImage() {
        this.previewImage = '';
        this.forImage = '';
    }
}
