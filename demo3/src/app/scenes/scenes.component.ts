import { Component, OnInit } from '@angular/core';
import { ChRouteService } from 'src/service/ch-route.service';

declare var CrComLib: any;

@Component({
  selector: 'app-scenes',
  templateUrl: './scenes.component.html',
  styleUrls: ['./scenes.component.scss'],
})
export class ScenesComponent implements OnInit {
  constructor(public rout: ChRouteService) { }

  value: string;
  activeZones: number[];
  activeZonee = [1, 2, 4];
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
}




//min="0" max="65535"