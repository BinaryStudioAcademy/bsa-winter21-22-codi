import {Injectable} from '@angular/core';
import {Router} from "@angular/router";
import {AngularFireAuth} from "@angular/fire/compat/auth";
import firebase from 'firebase/compat/app';
import {BehaviorSubject, map, Observable} from "rxjs";
import {CurrentUser} from "@core/models/current-user";
import {HttpClient} from "@angular/common/http";


@Injectable({
  providedIn: 'root'
})
export class AuthService {

  user$: BehaviorSubject<CurrentUser> = new BehaviorSubject<CurrentUser>(new CurrentUser());
  constructor(
    private afAuth: AngularFireAuth,
    private router: Router,
    private http: HttpClient
  ) {
    this.afAuth.authState.subscribe((firebaseUser) => {
      if (firebaseUser) {
        this.configureAuthState(firebaseUser)
      }
    })

  }

  configureAuthState(firebaseUser: firebase.User) {
    if(firebaseUser) {
      firebaseUser.getIdToken().then((theToken) => {
        console.log('we have a token');
        this.http.post('http://localhosts:5050/token/verify', {token: theToken})
          .subscribe({
            next: () => {
              let theUser = new CurrentUser();
              theUser.displayName = firebaseUser.displayName;
              theUser.email = firebaseUser.email;
              theUser.isSignedIn = true;
              localStorage.setItem("jwt", theToken);
              this.user$.next(theUser);
            },
            error: (err) => {
              console.log('inside the error from server', err);
              this.doSignedOutUser()
            }
          });
      });
    } else {
      this.doSignedOutUser();
    }
  }

  private doSignedOutUser() {
    let theUser = new CurrentUser();
    theUser.displayName = null;
    theUser.email = null;
    theUser.isSignedIn = false;
    localStorage.removeItem("jwt");
    this.user$.next(theUser);
  }

 googleSignIn() {
    const provider = new firebase.auth.GoogleAuthProvider();
    provider.addScope('email');
    provider.addScope('profile')
    return this.afAuth.signInWithPopup(provider);
  }

  getToken() {
    return localStorage.getItem("jwt");
  }

  getUserObservable(): Observable<CurrentUser> {
    return this.user$.asObservable();
  }

  getUserSecrets(): Observable<any> {
    return this.http.get("https://localhost:5050/token/secrets").pipe(map((resp) => resp));
  }

  logout(): Promise<void> {
    return this.afAuth.signOut();
  }


}
