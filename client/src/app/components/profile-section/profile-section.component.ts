import { Component, Input, OnInit } from '@angular/core';
import { LoginPageComponent } from '../login-page/login-page.component';
import { User } from "../../models/user";

@Component({
  selector: 'app-profile-section',
  templateUrl: './profile-section.component.html',
  styleUrls: ['./profile-section.component.css']
})
export class ProfileSectionComponent implements OnInit {
  // user : User | undefined;
  userFollowers : number = 0;
  userFollowing : number = 0;
  userPostsNumber : number = 0;
  userName : string = "";
  user = localStorage.getItem("user");

  constructor() { }

  ngOnInit(): void {
    this.getUser();
  }
  getUser(){
    if(this.user != undefined){
      let userInfos = JSON.parse(this.user);
      this.userName = userInfos.username;
      this.userFollowers = userInfos.followers.length();
      this.userFollowing = userInfos.following.length();
      this.userPostsNumber = userInfos.posts.length();
    }
  }
}
