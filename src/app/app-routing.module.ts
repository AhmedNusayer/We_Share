import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PlanTripComponent } from './plan-trip/plan-trip.component';
import { RequestTripComponent } from './request-trip/request-trip.component';
import { HomePageComponent } from './home-page/home-page.component';
import { ServicesPageComponent } from './services-page/services-page.component';
import { AboutPageComponent } from './about-page/about-page.component';
import {LoginComponent} from './login/login.component';
import { ShowRequestComponent } from './show-request/show-request.component';
import { ShowPlanComponent } from './show-plan/show-plan.component';

const routes: Routes = [
  {path: '', component: LoginComponent },
  {path: 'Home', component: HomePageComponent },
  {path: 'plan', component: PlanTripComponent},
  {path: 'request', component: RequestTripComponent},
  {path: 'services', component: ServicesPageComponent },
  {path: 'about', component: AboutPageComponent },
  {path: 'show-request', component: ShowRequestComponent },
  {path: 'show-plan', component: ShowPlanComponent },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
