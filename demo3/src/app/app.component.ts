import { Component, ViewChild, ElementRef, Inject } from '@angular/core';
import { ChRouteService } from 'src/service/ch-route.service';
import { DOCUMENT } from '@angular/common';
import { ConfigService } from 'src/service/config.service';

import { UserIdleService } from 'angular-user-idle';

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
    private configService: ConfigService,
    private userIdle: UserIdleService
  ) { }
  activeflag: any;

  activeflag1: any;

  testing: any;


  ngOnInit() {

    this.rout.active = 0;
    this.loadEmulator();
    let self = this;

    setInterval(function () {


      if (self.rout.active == 5 || self.rout.active == 6) {
        self.activeflag = { 'height': '100vh' };

        self.activeflag1 = { 'display': 'none' };
      }

      if (self.rout.active == 0) {
        self.activeflag = { 'height': '91vh' };

        self.activeflag1 = { 'display': 'grid' };

      }



    }, 50);
    //Start watching for user inactivity.
    this.userIdle.startWatching();

    // Start watching when user idle is starting.
    this.userIdle.onTimerStart().subscribe(count => console.log(count));

    // Start watch when time is up.
    this.userIdle.onTimeout().subscribe(() =>
      self.rout.active = 6
    );
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
