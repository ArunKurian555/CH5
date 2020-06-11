import { ColorEvent } from 'ngx-color';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-dmxpop',
  templateUrl: './dmxpop.component.html',
  styleUrls: ['./dmxpop.component.scss']
})
export class DmxpopComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  handleChange($event: ColorEvent) {
    // color = {
    //   hex: '#333',
    //   rgb: {
    //     r: 51,
    //     g: 51,
    //     b: 51,
    //     a: 1,
    //   },
    //   hsl: {
    //     h: 0,
    //     s: 0,
    //     l: .20,
    //     a: 1,
    //   },
    // }
  }


}
