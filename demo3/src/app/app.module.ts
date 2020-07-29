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
import { MatGridListModule } from '@angular/material/grid-list';
import { ColorSketchModule } from 'ngx-color/sketch';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';

import { View4Component } from './view4/view4.component';
import { View5Component } from './view5/view5.component';
import { DmxpopComponent } from './dmxpop/dmxpop.component';
import { NoopAnimationsModule } from '@angular/platform-browser/animations'
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { ColorChromeModule } from 'ngx-color/chrome';
import { MatSliderModule } from '@angular/material/slider';
import { AreapopComponent } from './areapop/areapop.component'; // <color-chrome></color-chrome>
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { EditnameComponent } from './editname/editname.component';
import { EditorpageComponent } from './editorpage/editorpage.component';
import { RamptimeComponent } from './ramptime/ramptime.component';
import { ScenepopComponent } from './scenepop/scenepop.component';
import { ConfirmationComponent } from './confirmation/confirmation.component';
import { SettimeComponent } from './settime/settime.component';
@NgModule({
  declarations: [AppComponent, ScenesComponent, UtilitiesComponent, View3Component, View4Component, View5Component, DmxpopComponent, AreapopComponent, EditnameComponent, EditorpageComponent, RamptimeComponent, ScenepopComponent, ConfirmationComponent, SettimeComponent],
  imports: [BrowserModule, FontAwesomeModule, ScrollingModule, ColorSketchModule, NoopAnimationsModule, BrowserAnimationsModule, MatDialogModule, ColorChromeModule, MatSliderModule, FormsModule, MatGridListModule, MatSlideToggleModule, MatButtonModule],
  providers: [
    { provide: APP_BASE_HREF, useValue: './' },
    ChRouteService,
    ConfigService,
  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
  bootstrap: [AppComponent],
})
export class AppModule { }
