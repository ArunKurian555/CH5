import { BrowserModule } from '@angular/platform-browser';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';

import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

import { AppComponent } from './app.component';
import { APP_BASE_HREF } from '@angular/common';
import { ScenesComponent } from './scenes/scenes.component';
import { ChRouteService } from 'src/service/ch-route.service';
import { UtilitiesComponent } from './utilities/utilities.component';
import { ConfigService } from 'src/service/config.service';
import { View3Component } from './view3/view3.component';
import { ScrollingModule } from '@angular/cdk/scrolling';
import { View4Component } from './view4/view4.component'

@NgModule({
  declarations: [AppComponent, ScenesComponent, UtilitiesComponent, View3Component, View4Component],
  imports: [BrowserModule, FontAwesomeModule, ScrollingModule],
  providers: [
    { provide: APP_BASE_HREF, useValue: './' },
    ChRouteService,
    ConfigService,
  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
  bootstrap: [AppComponent],
})
export class AppModule { }
