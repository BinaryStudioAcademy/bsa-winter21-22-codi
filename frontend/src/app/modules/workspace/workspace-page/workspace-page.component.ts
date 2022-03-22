import { Component } from '@angular/core';

@Component({
    selector: 'app-workspace-page',
    templateUrl: './workspace-page.component.html',
    styleUrls: ['./workspace-page.component.sass']
})
export class WorkspacePageComponent {
    editorOptions = {theme: 'vs-dark', language: 'javascript', scrollBeyondLastLine: false};
    code: string= 'function x() {\nconsole.log("Hello world!");\n}';
}
