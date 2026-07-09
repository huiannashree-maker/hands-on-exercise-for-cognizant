// app-routing.module.ts
{ path: 'courses', loadChildren: () => import('./features/enrollment/enrollment.module').then(m => m.EnrollmentModule) },
{ path: 'profile', canActivate: [AuthGuard], component: StudentProfileComponent }