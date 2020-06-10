import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/_models/user';
import { UserService } from 'src/app/_services/user.service';
import { AlertifyService } from 'src/app/_services/alertify.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-member-detail',
  templateUrl: './member-detail.component.html',
  styleUrls: ['./member-detail.component.css']
})
export class MemberDetailComponent implements OnInit {
  user:User;

  constructor(private userService:UserService,private alertify:AlertifyService,private route:ActivatedRoute) { }

  ngOnInit() {
    this.route.data.subscribe(data=>{
      this.user=data['user'];
    });

    
  }

  // getImages(){
  //   const imageUrls=[];
  //   for(const photo of this.user.photos){
  //     imageUrls.push({
  //       small:photo.utl,
  //       medium:photo.utl,
  //       big:photo.utl,
  //       description:photo.description
  //     });
  //   }
  //   return imageUrls;
  // }

  // loadUser(){
  //   this.userService.getUser(+this.route.snapshot.params['id']).subscribe((user:User)=>{
  //     this.user=user;
  //   },error =>{
  //      this.alertify.error(error);
  //   });
  // }

}
