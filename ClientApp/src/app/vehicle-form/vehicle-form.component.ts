import { Component, OnInit } from '@angular/core';
import { MakeService } from '../services/make.service';


@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {

  public makes: any[] ;
  public models: any[];
  public vehicle: any={};

  constructor(private makeService:MakeService) { }

  ngOnInit() {
    this.makeService.getMakes().subscribe(res => 
      {
        this.makes = Object.keys(res).map(i => res[i]);           

       // console.log("Makes-",res, this.data);
      }
    );
  }

  onMakeChange(){
   // console.log(this.vehicle);
    var selectedMake = this.makes.find(m => m.id == this.vehicle.make);

    this.models = selectedMake?selectedMake.models:[];


  }

}
