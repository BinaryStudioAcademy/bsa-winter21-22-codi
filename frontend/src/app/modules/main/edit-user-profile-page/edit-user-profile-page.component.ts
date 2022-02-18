import { Component, OnInit } from '@angular/core';
import { AuthService } from "@core/services/auth.service";
import { UserService } from "@core/services/user.service";
import { FormControl, FormGroup, Validators } from "@angular/forms";
import { Router } from "@angular/router";
import { BaseComponent } from "@core/base/base.component";
import { takeUntil } from "rxjs";
import { User } from "@core/models/user/user";
import { UpdateUser } from "@core/models/user/update-user";
import { NotificationService } from "@core/services/notification.service";

@Component({
  selector: 'app-edit-user-profile-page',
  templateUrl: './edit-user-profile-page.component.html',
  styleUrls: ['./edit-user-profile-page.component.sass']
})
export class EditUserProfilePageComponent extends BaseComponent implements OnInit {

  public user: User;
  form: FormGroup;
  public imageFile: File;

  constructor(
    private authService: AuthService,
    private userService: UserService,
    private notificationService: NotificationService,
    private router: Router
  ) {
    super();
  }

  ngOnInit(): void {
    this.form = new FormGroup({
      userName: new FormControl('', Validators.required),
      firstName: new FormControl(''),
      lastName: new FormControl(''),
      bio: new FormControl('')
    });

    this.authService
      .getCurrentUser()
      .pipe(takeUntil(this.unsubscribe$))
      .subscribe(user => {
        this.user = user;
        this.form.patchValue(user);
      })
  }

  updateUser() {
    let formValue = this.form.value;
    let updatedUser =
      {
        id : this.user.id,
        userName: formValue.userName,
        firstName : formValue.firstName,
        lastName : formValue.lastName,
        bio: formValue.bio,
      } as UpdateUser;
    this.userService
      .update(updatedUser)
      .subscribe((user) => {
        this.authService.setUser(user.body!);
        this.router.navigate(['main/profile']);
      });
  }

  public handleFileInput(target: any) {
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
    reader.addEventListener('load', () => (this.user.avatar = reader.result as string));
    reader.readAsDataURL(this.imageFile);
  }
}
