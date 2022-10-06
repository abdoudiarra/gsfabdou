import { Component, Input, OnInit } from '@angular/core';
import { LoginPageComponent } from '../login-page/login-page.component';
import { User } from "../../models/user";
import 'flowbite';


@Component({
  selector: 'app-profile-section',
  templateUrl: './profile-section.component.html',
  styleUrls: ['./profile-section.component.css']
})
export class ProfileSectionComponent implements OnInit {
  // user : User | undefined;
  showDialog = false;
  userFollowers : number = 0;
  userFollowing : number = 0;
  userPostsNumber : number = 0;
  userName : string = "";
  user = localStorage.getItem("user");

  constructor() { }

  ngOnInit(): void {
    console.log("in");
    this.getUser();
  }
  getUser(){
    console.log(this.user);
    if(this.user != undefined){
      let userInfos = JSON.parse(this.user);
      this.userName = userInfos.username;
      this.userFollowers = 0 ;
      this.userFollowing = 0;
      this.userPostsNumber = 0;
    }
  }

  showDialogModal(){
    if(this.showDialog == true){
      this.showDialog = false;
    }
    this.showDialog = true;

  }
}
