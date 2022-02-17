import { Injectable } from '@angular/core';
import { from } from "rxjs";
import { Auth, authState, createUserWithEmailAndPassword, signInWithEmailAndPassword, signInWithPopup } from "@angular/fire/auth";
import { GoogleAuthProvider, GithubAuthProvider } from "firebase/auth";
import { idToken } from "rxfire/auth";
import {Router} from "@angular/router";
import {NotificationService} from "@core/services/notification.service";

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  currentUser$ = authState(this.auth);

  constructor(
    private auth: Auth,
    private router: Router,
    private notificationService: NotificationService
  ) {
    this.currentUser$.subscribe(user => {
      if (user) {
        user.getIdToken(true).then(token => {
          localStorage.setItem('jwt', token)
        });
      }
    })
  }

  signUp(username: string, email: string, password: string) {
    return from(createUserWithEmailAndPassword(this.auth, email, password).then(() => {
        this.router.navigate(['main']).then(() => {
          this.notificationService.showSuccessMessage("You have successfully register and logged in", "Welcome back!")
        })
      })
        .catch((error) => {
          this.notificationService.showErrorMessage(error)
        })
    );
  }

  signIn(email: string, password: string) {
    return from(signInWithEmailAndPassword(this.auth, email, password).then(() => {
      this.router.navigate(['main']).then(() => {
        this.notificationService.showSuccessMessage("You have successfully logged in", "Welcome back!")
      })
    })
      .catch((error) => {
        this.notificationService.showErrorMessage(error)
      })
    );
  }

  logOut() {
    return from(this.auth.signOut().then(() => {
      localStorage.removeItem('jwt')
    }));
  }

  withGoogle() {
    return from(this.authLogin(new GoogleAuthProvider())).subscribe(() => {
      this.router.navigate(['main']).then(() => {
        this.notificationService.showSuccessMessage("You have successfully logged in", "Welcome back!")
      })
        .catch((error) => {
          this.notificationService.showErrorMessage(error)
        })
    });
  }

  withGitHub() {
    return from(this.authLogin(new GithubAuthProvider())).subscribe(() => {
      this.router.navigate(['main']).then(() => {
        this.notificationService.showSuccessMessage("You have successfully logged in", "Welcome back!")
      })
        .catch((error) => {
          this.notificationService.showErrorMessage(error)
        })
    });
  }

  authLogin(provider: any) {
    return from(signInWithPopup(this.auth, provider))
  }

  getAuthIdToken() {
    return from(idToken(this.auth))
  }
}
