import { Component, OnInit, EventEmitter, Output } from '@angular/core';

import { MatDialog } from '@angular/material/dialog';
import { AreapopComponent } from '../areapop/areapop.component';
import { EditnameComponent } from '../editname/editname.component';

declare var CrComLib: any;
@Component({
  selector: 'app-view4',
  templateUrl: './view4.component.html',
  styleUrls: ['./view4.component.scss']
})


export class View4Component implements OnInit {
  constructor(public dialog: MatDialog) { }

  ngOnInit(): void {

  }



  editname() {
    const dialogRef = this.dialog.open(EditnameComponent, {
      height: '80vh',
      width: '80vw',
    });
  }
}