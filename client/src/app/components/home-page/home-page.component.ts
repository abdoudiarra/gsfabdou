import { Component, Input, OnInit } from '@angular/core';
import { User } from 'src/app/models/user';
import { LoginPageComponent } from '../login-page/login-page.component';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.css']
})
export class HomePageComponent implements OnInit {
  user = localStorage.getItem("user");
  userInfos :string ="";

  constructor() { }

  ngOnInit(): void {

  }

  getUser(){
    if(this.user != undefined){
      this.userInfos = JSON.parse(this.user);
    }
  }
}
