import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from "@angular/forms";
import { ConfirmationDialogResult } from '@core/models/confirmation-dialog/confirmation-dialog-result';
import { ConfirmationDialogService } from '@core/services/confirmation-dialog.service';
import { NotificationService } from '@core/services/notification.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.sass']
})
export class LoginComponent implements OnInit {
  form!: FormGroup

  constructor(private notificationService: NotificationService, private confirmationDialogService: ConfirmationDialogService) {}

  ngOnInit(): void {
    this.form = new FormGroup({
      login: new FormControl('', Validators.required),
      password: new FormControl('', Validators.required)
    })
  }

  showTestConfirmationDialogAndSuccessMessage() {
    this.notificationService.showSuccessMessage("You have successfully logged in", "Welcome back!");

    this.confirmationDialogService.openConfirmationDialog("Get started with Codi",
      `<p>Lorem, ipsum dolor sit amet consectetur adipisicing elit. Aperiam quasi accusantium, 
    commodi voluptas explicabo pariatur vitae exercitationem natus nihil qui sunt voluptates dignissimos 
    libero dolor, id veritatis doloribus fugit! Nemo?</p>
    <iframe style="width: 100%; height: 260px" src="https://www.youtube.com/embed/N4o0qnSeVQQ" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>`
      , {
        allowHtmlContent: true,
        cancelButton: false,
        confirmButtonText: "OK"
      }).subscribe({
        next: result => {
          this.notificationService.showSuccessMessage(`${ConfirmationDialogResult[result]}`, "Dialog result");
        }
      });
  }
}
