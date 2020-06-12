import { Component, OnInit } from '@angular/core';

declare var CrComLib: any;
@Component({
  selector: 'app-view4',
  templateUrl: './view4.component.html',
  styleUrls: ['./view4.component.scss']
})


export class View4Component implements OnInit {
  constructor() { }
  headingCss = {
    'color': 'red',
    'font-weight': 'bold',
    'background-color': 'black',
    'width': '2em',
    'height': '2em'
  };

  htmlVariable: string = "<b>Some html.</b>";
  ngOnInit(): void {
    this.headingCss["background-color"] = 'blue';

  }

}