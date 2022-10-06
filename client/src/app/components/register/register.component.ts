import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { User } from 'src/app/models/user';
import { AccountService } from 'src/app/services/account.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  model: any = {};
  registered:boolean = false;
  user : User | undefined

  constructor(private accountService: AccountService ,private route: ActivatedRoute ,private router: Router) { }

  ngOnInit(): void {

  }

  register(){
    console.log(this.model);
    this.accountService.register(this.model).subscribe(response => {
      this.registered = true;
      this.router.navigate([''], { relativeTo: this.route });
    },error => {
      console.log(error)
    })
  }
}

