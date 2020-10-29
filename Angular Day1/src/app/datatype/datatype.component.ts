import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-datatype',
  templateUrl: './datatype.component.html',
  styleUrls: ['./datatype.component.css']
})
export class DatatypeComponent implements OnInit {
  name:string="Arulselvan";
  age:number;
  hobbies:string[];
  marks:Array<number>;
  istrue:boolean;
  student:object;
  tupleval:[string, number, boolean];
  dynamicvalue:any;

  picture="assets/Images/logo.png";

  constructor() { 
    this.age=25;
    this.hobbies=["playing", "chess","cricket"];
    this.marks=[86,90,79];
    this.istrue=false;
    this.tupleval=["arul",23,true];
    this.student={Fathername:"Balasubramanian",City:"trichy"}
    this.dynamicvalue="hai";
    this.dynamicvalue="true";
  }


  ngOnInit(){
  }

}
