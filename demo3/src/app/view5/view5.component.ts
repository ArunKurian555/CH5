import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { View4Component } from '../view4/view4.component';

import { ChRouteService } from 'src/service/ch-route.service';

import { MatDialog } from '@angular/material/dialog';
import { DmxpopComponent } from '../dmxpop/dmxpop.component';
import { SelectorFlags } from '@angular/compiler/src/core';

declare var CrComLib: any;

@Component({
  selector: 'app-view5',
  templateUrl: './view5.component.html',
  styleUrls: ['./view5.component.scss'],

})
export class View5Component implements OnInit {
  constructor(public dialog: MatDialog) { }

  ngOnInit(): void {
  }
}

