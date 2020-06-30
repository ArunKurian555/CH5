import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import { MatSliderChange } from '@angular/material/slider';

declare var CrComLib: any;
@Component({
  selector: 'app-view4',
  templateUrl: './view4.component.html',
  styleUrls: ['./view4.component.scss']
})


export class View4Component implements OnInit {
  constructor() { }
  myModel = [];

  activeZones = [1, 3, 5, 7, 9, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21];

  formatLabel(value: number) {
    if (value >= 655) {
      return Math.round(value / 655.35) + '%';
    }
    return value;
  }
  ngOnInit(): void {


  }
}