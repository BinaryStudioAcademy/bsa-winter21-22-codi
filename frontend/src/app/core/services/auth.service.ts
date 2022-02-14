import {Injectable} from '@angular/core';
import { from, switchMap} from "rxjs";
import {
  Auth,
  authState,
  createUserWithEmailAndPassword,
  signInWithEmailAndPassword,
  signInWithPopup,
  updateProfile,
} from "@angular/fire/auth";
import { GoogleAuthProvider, GithubAuthProvider } from "firebase/auth";

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  currentUser$ = authState(this.auth);
  token?: any;

  constructor(private auth: Auth) {
    this.currentUser$.subscribe( user =>{
      if (user) {
        user.getIdToken(true).then(theToken => {
          this.token = theToken
          localStorage.setItem('jwt', JSON.stringify(this.token));
        })
      }
      else {
        localStorage.removeItem('jwt');
        this.token = null;
      }
    })
  }

  signUp(username:string, email: string, password: string) {
    return from(createUserWithEmailAndPassword(this.auth, email, password))
      .pipe(
        switchMap(({user}) => updateProfile(user, {displayName: username}))
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

  authLogin(provider:any) {
    return from(signInWithPopup(this.auth,provider))
  }
}



