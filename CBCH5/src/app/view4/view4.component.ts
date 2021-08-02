import { Component, OnInit, EventEmitter, Output } from '@angular/core';

import { MatDialog } from '@angular/material/dialog';
import { ChRouteService } from 'src/service/ch-route.service';
import { AreapopComponent } from '../areapop/areapop.component';
import { EditnameComponent } from '../editname/editname.component';
import { RamptimeComponent } from '../ramptime/ramptime.component';

declare var CrComLib: any;
@Component({
  selector: 'app-view4',
  templateUrl: './view4.component.html',
  styleUrls: ['./view4.component.scss']
})


export class View4Component implements OnInit {
  constructor(public dialog: MatDialog,
    public rout: ChRouteService,) { }

  ngOnInit(): void {

  }
  
  onClick(id: number) {
    let self = this;
    this.rout.active = id - 1;

  }



  editname() {
    const dialogRef = this.dialog.open(EditnameComponent, {
      height: '80vh',
      width: '80vw',
    });
  }
  clicked(event) {
    event.target.classList.add("animate__animated", "animate__rotateIn"); // To ADD

    setTimeout(() => {
      event.target.classList.remove("animate__animated", "animate__rotateIn"); // To Remove
    }, 2000);


    CrComLib.publishEvent('b', 1202, true);
    CrComLib.publishEvent('b', 1202, false);
  }

  clicked2(event) {
    CrComLib.publishEvent('b', 1202, true);
    CrComLib.publishEvent('b', 1202, false);
  }


  ramptime() {
    const dialogRef = this.dialog.open(RamptimeComponent, {

    });

  }
}