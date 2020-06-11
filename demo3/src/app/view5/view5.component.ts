import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { View4Component } from '../view4/view4.component';

import { ChRouteService } from 'src/service/ch-route.service';

import { MatDialog } from '@angular/material/dialog';
import { DmxpopComponent } from '../dmxpop/dmxpop.component';

declare var CrComLib: any;

@Component({
  selector: 'app-view5',
  templateUrl: './view5.component.html',
  styleUrls: ['./view5.component.scss'],
  encapsulation: ViewEncapsulation.None,

})
export class View5Component implements OnInit {
  constructor(public dialog: MatDialog) { }

  value: string;
  activeZones: number[];
  activeZonee = [1, 2, 4];
  DMXactive = [1, 0, 1, 0]
  htmlToAdd: string = '<div class = "dmxfb" >  </div>';
  ngOnInit(): void {
    let self = this; //this statement binds the object that you want to self;

    const sig22SubKey = CrComLib.subscribeState('s', '1', function (value) {
      self.value = value;
      let items = [];
      for (let i = 0; i < self.value.length; i++) {
        if (self.value[i] === "1") {
          items.push(i / 2 + 1);
        }
      }
      self.activeZones = items;
    });

    setInterval(function () { }, 1000);
    /* 
setInterval(function () {
  let items = [];
  const sigValue = CrComLib.getState('s', '1', true);
  self.value = sigValue;
  for (let i = 0; i < self.value.length; i++) {
    if (self.value[i] === "1") {
      items.push(i / 2 + 1);
    }
  }
  self.activeZones = items;
}, 3000); */
  }


  DMXcall(id: number) {
    const dialogRef = this.dialog.open(DmxpopComponent, {
      width: '80%',
      data: id,
    });

  }
}

