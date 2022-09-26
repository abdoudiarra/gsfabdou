import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ConversationSectionComponent } from './components/conversation-section/conversation-section.component';
import { HomePageComponent } from './components/home-page/home-page.component';
import { LoginPageComponent } from './components/login-page/login-page.component';
import { NotificationsSectionComponent } from './components/notifications-section/notifications-section.component';
import { ProfileSectionComponent } from './components/profile-section/profile-section.component';
import { RegisterComponent } from './components/register/register.component';
import { SavedSectionComponent } from './components/saved-section/saved-section.component';

const routes: Routes = [
  {path : 'home-page', component: HomePageComponent,
    children: [
      {path: 'profile-page', component: ProfileSectionComponent},
      {path: 'conversations', component: ConversationSectionComponent},
      {path: 'notifications', component: NotificationsSectionComponent},
      {path: 'saved', component: SavedSectionComponent},
  ]},
  { path : "home-page/profile-page", component : ProfileSectionComponent },
  { path : "home-page/conversations", component : ConversationSectionComponent },
  { path : "home-page/notifications", component : NotificationsSectionComponent },
  { path : "home-page/saved", component : SavedSectionComponent },
  { path : "register", component : RegisterComponent },
  { path : "", component : LoginPageComponent }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
export const routingComponents = [HomePageComponent, ProfileSectionComponent, ConversationSectionComponent, NotificationsSectionComponent, SavedSectionComponent, RegisterComponent, LoginPageComponent];
