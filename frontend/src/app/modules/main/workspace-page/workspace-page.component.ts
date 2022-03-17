import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-workspace-page',
  templateUrl: './workspace-page.component.html',
  styleUrls: ['./workspace-page.component.sass']
})
export class WorkspacePageComponent implements OnInit {

  editorOptions = {theme: 'vs-dark', language: 'javascript', scrollBeyondLastLine: false};
  code: string= 'function x() {\nconsole.log("Hello world!");\n}';
  constructor() { }

  ngOnInit(): void {
  }

}
