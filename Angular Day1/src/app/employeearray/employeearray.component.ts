import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-employeearray',
  templateUrl: './employeearray.component.html',
  styleUrls: ['./employeearray.component.css']
})
export class EmployeearrayComponent implements OnInit {
  people:any[]=[
    {"name":"Arul","age":23,"Dept":"ONG"},
    {"name":"Selvan","age":23,"Dept":"IT"},
    {"name":"Ramya","age":27,"Dept":"HR"},
    {"name":"Prema","age":54,"Dept":"Finance"}
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
