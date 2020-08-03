import { Component, OnInit } from '@angular/core';
import { ChRouteService } from 'src/service/ch-route.service';
import { CdkDragEnd } from '@angular/cdk/drag-drop';
import { MatDialog } from '@angular/material/dialog';
import { FpzonecontrolComponent } from '../fpzonecontrol/fpzonecontrol.component';

declare var CrComLib: any;

@Component({
  selector: 'app-view7',
  templateUrl: './view7.component.html',
  styleUrls: ['./view7.component.scss']
})
export class View7Component implements OnInit {
  dragPosition = { x: 0, y: 0 };
  positionarray = [];
  constructor(public rout: ChRouteService, public dialog: MatDialog) { }
  items = [1, 2, 3, 4, 5, 6];

  ngOnInit(): void {
    for (let index = 0; index < this.items.length + 1; index++) {
      this.positionarray.push(this.dragPosition);
    }
    this.positionarray = JSON.parse(localStorage.getItem("savedData"))[0];
  }
  onclick() {
    this.rout.active = 5;
  }
  controlpop(i) {
    CrComLib.publishEvent('b', "Area.AreaSelect" + i, true);
    CrComLib.publishEvent('b', "Area.AreaSelect" + i, false);

    const dialogRef = this.dialog.open(FpzonecontrolComponent, {
    });
  }
  public onDragEnded(event: CdkDragEnd, a): void {
    this.positionarray[a + 1] = event.source.getFreeDragPosition();
    localStorage.setItem("savedData", JSON.stringify([this.positionarray]));


    /* localStorage.setItem("savedData", JSON.stringify([object1, object2]));
    object1 = JSON.parse(localStorage.getItem("savedData"))[0];
    object2 = JSON.parse(localStorage.getItem("savedData"))[1];
     */
  }
}
