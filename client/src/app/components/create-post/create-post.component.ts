import { Component, OnInit } from '@angular/core';
import { Posts } from 'src/app/models/posts';
import { AccountService } from 'src/app/services/account.service';

@Component({
  selector: 'app-create-post',
  templateUrl: './create-post.component.html',
  styleUrls: ['./create-post.component.css']
})
export class CreatePostComponent implements OnInit {
  model: any = {};
  modalSaveShow = false;
  saved:boolean = false;
  post : Posts | undefined

  constructor(private accountService: AccountService) { }


  ngOnInit(): void {
  }

  publishPost(){
    this.accountService.publishPost(this.model).subscribe(response =>{
      this.model.appuserid = 
      this.model.liked = false;
      this.model.saved = false;
      console.log(this.model);
    })
  }
}
