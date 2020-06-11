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
import { ColorSketchModule } from 'ngx-color/sketch';

import { View4Component } from './view4/view4.component';
import { View5Component } from './view5/view5.component';
import { DmxpopComponent } from './dmxpop/dmxpop.component';
import { NoopAnimationsModule } from '@angular/platform-browser/animations'
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { ColorChromeModule } from 'ngx-color/chrome'; // <color-chrome></color-chrome>

@NgModule({
  declarations: [AppComponent, ScenesComponent, UtilitiesComponent, View3Component, View4Component, View5Component, DmxpopComponent],
  imports: [BrowserModule, FontAwesomeModule, ScrollingModule, ColorSketchModule, NoopAnimationsModule, BrowserAnimationsModule, MatDialogModule, ColorChromeModule],
  providers: [
    { provide: APP_BASE_HREF, useValue: './' },
    ChRouteService,
    ConfigService,
  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
  bootstrap: [AppComponent],
})
export class AppModule { }
