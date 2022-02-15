import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from '@shared/components/not-found/not-found.component';

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
    },
    {
        path: '',
        loadChildren: () =>
          import('./modules/auth/auth.module')
            .then(m => m.AuthModule),
    },
    {   
        path: '**',
        component: NotFoundComponent,
        pathMatch: 'full'
     },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }
