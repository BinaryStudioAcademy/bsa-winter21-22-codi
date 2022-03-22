import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from '@shared/components/not-found/not-found.component';
import { canActivate, redirectUnauthorizedTo, redirectLoggedInTo } from '@angular/fire/auth-guard';

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
        ...canActivate(redirectToLogin),
    },
    {
        path: '',
        loadChildren: () =>
            import('./modules/auth/auth.module')
                .then(m => m.AuthModule),
        ...canActivate(redirectToMain),
    },
    { 
        path: 'user/:id',
        loadChildren: () =>
            import('./modules/user/user.module')
                .then(m => m.UserModule),
        ...canActivate(redirectToLogin),
    },            
    { 
        path: 'workspace',
        loadChildren: () => 
            import('./modules/workspace/workspace.module')
                .then(m => m.WorkspaceModule),
        ...canActivate(redirectToLogin),
    },
    {
        path: '**',
        component: NotFoundComponent,
        pathMatch: 'full',
    },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule],
})
export class AppRoutingModule { }
