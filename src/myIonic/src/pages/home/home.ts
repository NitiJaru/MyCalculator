import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  answer : string;
  input: string;
  constructor(public navCtrl: NavController,private httpClient: HttpClient) {
    this.input = "1";
  }
  calculate() 
  {  
    this.httpClient.get("http://node16.codenvy.io:47446/api/Calculator/GetSecondAnswer/"+this.input)
      .subscribe((data: any) => {
        this.answer = data.secondAnswer;
        alert(data.secondAnswer);
      }, error => {
        // If error
      });
  } 
}
