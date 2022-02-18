import { Injectable } from '@angular/core';
import {from, map, of, Subject, switchMap, takeUntil} from "rxjs";
import { Auth, authState, createUserWithEmailAndPassword, signInWithEmailAndPassword, signInWithPopup, updateProfile, } from "@angular/fire/auth";
import { GoogleAuthProvider, GithubAuthProvider } from "firebase/auth";
import { idToken } from "rxfire/auth";
import { UserService } from "@core/services/user.service";
import { User } from "@core/models/user/user";

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  currentUser$ = authState(this.auth);

  private user: User;
  private unsubscribe$ = new Subject<void>();

  constructor(
    private auth: Auth,
    private userService: UserService
  ) {
    this.currentUser$.subscribe(user => {
      if (user) {
        user.getIdToken(true).then(token => {
          localStorage.setItem('jwt', token)
        });
      }
    })
  }

  getCurrentUser() {
    return this.user
      ? of(this.user)
      : this.currentUser$
      .pipe(
        switchMap((userResp) => this.userService.getCurrent(userResp?.email!)),
        takeUntil(this.unsubscribe$)
      ).pipe(
        map((resp) => {
          this.user = resp.body!;
          return this.user;
        })
      )
  }

  signUp(username: string, email: string, password: string) {
    return from(createUserWithEmailAndPassword(this.auth, email, password))
      .pipe(
        switchMap(({ user }) => updateProfile(user, { displayName: username }))
      );
  }

  signIn(email: string, password: string) {
    return from(signInWithEmailAndPassword(this.auth, email, password));
  }

  logOut() {
    return from(this.auth.signOut().then(() => {
      localStorage.removeItem('jwt')
    }));
  }

  withGoogle() {
    return from(this.authLogin(new GoogleAuthProvider()))
  }

  withGitHub() {
    return from(this.authLogin(new GithubAuthProvider()))
  }

  authLogin(provider: any) {
    return from(signInWithPopup(this.auth, provider))
  }

  getAuthIdToken() {
    return from(idToken(this.auth))
  }
}
