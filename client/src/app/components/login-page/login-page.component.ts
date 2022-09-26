import { Component, Input, OnInit } from '@angular/core';
import { AccountService } from 'src/app/services/account.service';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';
import { User } from 'src/app/models/user';


@Component({
  selector: 'app-login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.css']
})
export class LoginPageComponent implements OnInit {

  model: any = {};
  loggedIn:boolean = false;
  user : User | undefined

  constructor(private accountService: AccountService ,private route: ActivatedRoute ,private router: Router) { }

  ngOnInit(): void {

  }

  login(){
    console.log(this.model);
    this.accountService.login(this.model).subscribe(response => {
      console.log(response);
      this.loggedIn = true;
      console.log(this.loggedIn);
      this.model = this.user
      this.router.navigate(['/home-page/profile-page'], { relativeTo: this.route });
    },error => {
      console.log(error)
    })
  }
}
