import { Component, ViewChild, ElementRef, Inject } from '@angular/core';
import { ChRouteService } from 'src/service/ch-route.service';
import { DOCUMENT } from '@angular/common';
import { ConfigService } from 'src/service/config.service';
declare var CrComLib: any;

import * as lightingEmulator from 'src/assets/data/lighting-emulator.json';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  title = 'demo3';
  constructor(
    public rout: ChRouteService,
    private configService: ConfigService
  ) { }

  testing: any;


  ngOnInit() {
    this.rout.active = 0;
    this.loadEmulator();

  }

  onClick(id: number) {
    this.rout.active = id - 1;
  }

  /**
   * Map the emulator JSON file
   */
  private loadEmulator() {
    // Lighting Emulator
    this.configService.initEmulator(lightingEmulator.default);
  }


}
