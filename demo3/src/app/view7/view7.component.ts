import { Component, OnInit } from '@angular/core';
import { ChRouteService } from 'src/service/ch-route.service';
import { CdkDragEnd } from '@angular/cdk/drag-drop';

@Component({
  selector: 'app-view7',
  templateUrl: './view7.component.html',
  styleUrls: ['./view7.component.scss']
})
export class View7Component implements OnInit {
  dragPosition = { x: 0, y: 0 };
  constructor(public rout: ChRouteService,) { }

  ngOnInit(): void {
    this.dragPosition = { x: 765.3333740234375, y: 352 };


  }
  onclick() {


    this.rout.active = 5;

  }
  public onDragEnded(event: CdkDragEnd): void {
    console.log(event.source.getFreeDragPosition()); // returns { x: 0, y: 0 }
  }
}
