import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-view4',
  templateUrl: './view4.component.html',
  styleUrls: ['./view4.component.scss']
})
export class View4Component implements OnInit {

  constructor() { }

  htmlVariable: string = "<b>Some html.</b>";
  ngOnInit(): void {

  }
}
