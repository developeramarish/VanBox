import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

   registerActive = false;

  constructor() { }

  ngOnInit() {
  }

  registerToggle() {
    this.registerActive = true;
  }

  registerDeactive(cancelRegister: boolean) {
    console.log(cancelRegister);
    this.registerActive = cancelRegister;
  }

}
