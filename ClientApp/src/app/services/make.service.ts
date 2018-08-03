
import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from '../../../node_modules/rxjs/Observable';


@Injectable()
export class MakeService {

  constructor(private http: HttpClient) { }
  

  getMakes(){
    return this.http.get('/api/makes');
  }

}
