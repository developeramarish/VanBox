import { User } from './../../_models/user';
import { ActivatedRoute } from '@angular/router';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-member-edit',
  templateUrl: './member-edit.component.html',
  styleUrls: ['./member-edit.component.css']
})
export class MemberEditComponent implements OnInit {
  user: User;

  constructor(private router: ActivatedRoute) { }

  ngOnInit() {
    this.router.data.subscribe(data => {
      this.user = data['user'];
    });
  }

}
