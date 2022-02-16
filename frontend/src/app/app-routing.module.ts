import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {canActivate, redirectUnauthorizedTo, redirectLoggedInTo} from "@angular/fire/auth-guard";

const redirectToLogin = () => redirectUnauthorizedTo(['login']);
const redirectToMain = () => redirectLoggedInTo(['main']);

const routes: Routes = [
    {
        path: '',
        loadChildren: () =>
            import('./modules/landing/landing.module')
                .then(m => m.LandingModule),
    },
    {
        path: 'main',
        loadChildren: () => import('./modules/main/main.module')
            .then(m => m.MainModule),
        ...canActivate(redirectToLogin)
    },
    {
        path: '',
        loadChildren: () =>
          import('./modules/auth/auth.module')
            .then(m => m.AuthModule),
        ...canActivate(redirectToMain)
    },
    { path: '**', redirectTo: '', pathMatch: 'full' },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }
