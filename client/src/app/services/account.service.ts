import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ReplaySubject } from 'rxjs';
import { map, catchError } from 'rxjs/operators';
import { Posts } from '../models/posts';
import { User } from '../models/user';


@Injectable({
  providedIn: 'root'
})
export class AccountService {

  baseUrl = "https://localhost:5011/api/"
  private currentUserSource = new ReplaySubject<User>(1);
  currentUser$ = this.currentUserSource.asObservable();
  // persister le login


  constructor(private http : HttpClient) { }

  login(model : any){
    return this.http.post(this.baseUrl + "Account/login",model).pipe(map((response:any) => {
      const user = response

      if(user){
        user.id++;
        localStorage.setItem('user',JSON.stringify(user));
      }
    }))
  }

  register(model : any){
    return this.http.post<User>(this.baseUrl + "Account/register",model).pipe(
      map((user : User) => {
      if(user){
        localStorage.setItem("user", JSON.stringify(user));
        this.currentUserSource.next(user);
      }
    }))
  }

  logout(){
    localStorage.removeItem("user")
  }

  publishPost(model : any){
    return this.http.post<Posts>(this.baseUrl + "Post/PublishPost",model).pipe(
      map((post : Posts) => {
        if(post){
          localStorage.setItem("post", JSON.stringify(post));

        }
      }
    )
    )
  }
}
