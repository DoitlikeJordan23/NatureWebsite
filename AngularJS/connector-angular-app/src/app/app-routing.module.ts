// app-routing.module.ts

import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { AboutUsComponent } from './about-us/about-us.component';
import { DiscussionsComponent } from './discussions/discussions.component';
import { SignInComponent } from './sign-in/sign-in.component';
import { RatingsComponent } from './ratings/ratings.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'about-us', component: AboutUsComponent },
  { path: 'discussions', component: DiscussionsComponent },
  { path: 'sign-in', component: SignInComponent },
  { path: 'ratings', component: RatingsComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
