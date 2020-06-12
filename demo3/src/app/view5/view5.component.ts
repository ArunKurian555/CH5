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
  encapsulation: ViewEncapsulation.None,

})
export class View5Component implements OnInit {
  constructor(public dialog: MatDialog) { }

  dmxfb = [
  ];
  temp: number;
  value: string;
  numvalue: number;
  activeZones = [1, 2, 3, 4, 5];
  DMXactive = [1, 0, 1, 0, 1];
  htmlToAdd: string = '<div class = "dmxfb" >  </div>';
  ngOnInit(): void {
    let self = this; //this statement binds the object that you want to self;
    /////////////// Active Zones

    ////////////////// Active DMX Zones







    //////// DMX FB array

    for (let i = 0; i < 120; i++) {
      self.dmxfb.push({
        'background-color': 'rgb(0,0,0)'
      })
    }

    const sig3SubKey = CrComLib.subscribeState('s', '3', function (value) { self.dmxfb[0]['background-color'] = value; }); const sig4SubKey = CrComLib.subscribeState('s', '4', function (value) { self.dmxfb[1]['background-color'] = value; }); const sig5SubKey = CrComLib.subscribeState('s', '5', function (value) { self.dmxfb[2]['background-color'] = value; }); const sig6SubKey = CrComLib.subscribeState('s', '6', function (value) { self.dmxfb[3]['background-color'] = value; }); const sig7SubKey = CrComLib.subscribeState('s', '7', function (value) { self.dmxfb[4]['background-color'] = value; }); const sig8SubKey = CrComLib.subscribeState('s', '8', function (value) { self.dmxfb[5]['background-color'] = value; }); const sig9SubKey = CrComLib.subscribeState('s', '9', function (value) { self.dmxfb[6]['background-color'] = value; }); const sig10SubKey = CrComLib.subscribeState('s', '10', function (value) { self.dmxfb[7]['background-color'] = value; }); const sig11SubKey = CrComLib.subscribeState('s', '11', function (value) { self.dmxfb[8]['background-color'] = value; }); const sig12SubKey = CrComLib.subscribeState('s', '12', function (value) { self.dmxfb[9]['background-color'] = value; }); const sig13SubKey = CrComLib.subscribeState('s', '13', function (value) { self.dmxfb[10]['background-color'] = value; }); const sig14SubKey = CrComLib.subscribeState('s', '14', function (value) { self.dmxfb[11]['background-color'] = value; }); const sig15SubKey = CrComLib.subscribeState('s', '15', function (value) { self.dmxfb[12]['background-color'] = value; }); const sig16SubKey = CrComLib.subscribeState('s', '16', function (value) { self.dmxfb[13]['background-color'] = value; }); const sig17SubKey = CrComLib.subscribeState('s', '17', function (value) { self.dmxfb[14]['background-color'] = value; }); const sig18SubKey = CrComLib.subscribeState('s', '18', function (value) { self.dmxfb[15]['background-color'] = value; }); const sig19SubKey = CrComLib.subscribeState('s', '19', function (value) { self.dmxfb[16]['background-color'] = value; }); const sig20SubKey = CrComLib.subscribeState('s', '20', function (value) { self.dmxfb[17]['background-color'] = value; }); const sig21SubKey = CrComLib.subscribeState('s', '21', function (value) { self.dmxfb[18]['background-color'] = value; }); const sig22SubKey = CrComLib.subscribeState('s', '22', function (value) { self.dmxfb[19]['background-color'] = value; }); const sig23SubKey = CrComLib.subscribeState('s', '23', function (value) { self.dmxfb[20]['background-color'] = value; }); const sig24SubKey = CrComLib.subscribeState('s', '24', function (value) { self.dmxfb[21]['background-color'] = value; }); const sig25SubKey = CrComLib.subscribeState('s', '25', function (value) { self.dmxfb[22]['background-color'] = value; }); const sig26SubKey = CrComLib.subscribeState('s', '26', function (value) { self.dmxfb[23]['background-color'] = value; }); const sig27SubKey = CrComLib.subscribeState('s', '27', function (value) { self.dmxfb[24]['background-color'] = value; }); const sig28SubKey = CrComLib.subscribeState('s', '28', function (value) { self.dmxfb[25]['background-color'] = value; }); const sig29SubKey = CrComLib.subscribeState('s', '29', function (value) { self.dmxfb[26]['background-color'] = value; }); const sig30SubKey = CrComLib.subscribeState('s', '30', function (value) { self.dmxfb[27]['background-color'] = value; }); const sig31SubKey = CrComLib.subscribeState('s', '31', function (value) { self.dmxfb[28]['background-color'] = value; }); const sig32SubKey = CrComLib.subscribeState('s', '32', function (value) { self.dmxfb[29]['background-color'] = value; }); const sig33SubKey = CrComLib.subscribeState('s', '33', function (value) { self.dmxfb[30]['background-color'] = value; }); const sig34SubKey = CrComLib.subscribeState('s', '34', function (value) { self.dmxfb[31]['background-color'] = value; }); const sig35SubKey = CrComLib.subscribeState('s', '35', function (value) { self.dmxfb[32]['background-color'] = value; }); const sig36SubKey = CrComLib.subscribeState('s', '36', function (value) { self.dmxfb[33]['background-color'] = value; }); const sig37SubKey = CrComLib.subscribeState('s', '37', function (value) { self.dmxfb[34]['background-color'] = value; }); const sig38SubKey = CrComLib.subscribeState('s', '38', function (value) { self.dmxfb[35]['background-color'] = value; }); const sig39SubKey = CrComLib.subscribeState('s', '39', function (value) { self.dmxfb[36]['background-color'] = value; }); const sig40SubKey = CrComLib.subscribeState('s', '40', function (value) { self.dmxfb[37]['background-color'] = value; }); const sig41SubKey = CrComLib.subscribeState('s', '41', function (value) { self.dmxfb[38]['background-color'] = value; }); const sig42SubKey = CrComLib.subscribeState('s', '42', function (value) { self.dmxfb[39]['background-color'] = value; }); const sig43SubKey = CrComLib.subscribeState('s', '43', function (value) { self.dmxfb[40]['background-color'] = value; }); const sig44SubKey = CrComLib.subscribeState('s', '44', function (value) { self.dmxfb[41]['background-color'] = value; }); const sig45SubKey = CrComLib.subscribeState('s', '45', function (value) { self.dmxfb[42]['background-color'] = value; }); const sig46SubKey = CrComLib.subscribeState('s', '46', function (value) { self.dmxfb[43]['background-color'] = value; }); const sig47SubKey = CrComLib.subscribeState('s', '47', function (value) { self.dmxfb[44]['background-color'] = value; }); const sig48SubKey = CrComLib.subscribeState('s', '48', function (value) { self.dmxfb[45]['background-color'] = value; }); const sig49SubKey = CrComLib.subscribeState('s', '49', function (value) { self.dmxfb[46]['background-color'] = value; }); const sig50SubKey = CrComLib.subscribeState('s', '50', function (value) { self.dmxfb[47]['background-color'] = value; }); const sig51SubKey = CrComLib.subscribeState('s', '51', function (value) { self.dmxfb[48]['background-color'] = value; }); const sig52SubKey = CrComLib.subscribeState('s', '52', function (value) { self.dmxfb[49]['background-color'] = value; }); const sig53SubKey = CrComLib.subscribeState('s', '53', function (value) { self.dmxfb[50]['background-color'] = value; }); const sig54SubKey = CrComLib.subscribeState('s', '54', function (value) { self.dmxfb[51]['background-color'] = value; }); const sig55SubKey = CrComLib.subscribeState('s', '55', function (value) { self.dmxfb[52]['background-color'] = value; }); const sig56SubKey = CrComLib.subscribeState('s', '56', function (value) { self.dmxfb[53]['background-color'] = value; }); const sig57SubKey = CrComLib.subscribeState('s', '57', function (value) { self.dmxfb[54]['background-color'] = value; }); const sig58SubKey = CrComLib.subscribeState('s', '58', function (value) { self.dmxfb[55]['background-color'] = value; }); const sig59SubKey = CrComLib.subscribeState('s', '59', function (value) { self.dmxfb[56]['background-color'] = value; }); const sig60SubKey = CrComLib.subscribeState('s', '60', function (value) { self.dmxfb[57]['background-color'] = value; }); const sig61SubKey = CrComLib.subscribeState('s', '61', function (value) { self.dmxfb[58]['background-color'] = value; }); const sig62SubKey = CrComLib.subscribeState('s', '62', function (value) { self.dmxfb[59]['background-color'] = value; }); const sig63SubKey = CrComLib.subscribeState('s', '63', function (value) { self.dmxfb[60]['background-color'] = value; }); const sig64SubKey = CrComLib.subscribeState('s', '64', function (value) { self.dmxfb[61]['background-color'] = value; }); const sig65SubKey = CrComLib.subscribeState('s', '65', function (value) { self.dmxfb[62]['background-color'] = value; }); const sig66SubKey = CrComLib.subscribeState('s', '66', function (value) { self.dmxfb[63]['background-color'] = value; }); const sig67SubKey = CrComLib.subscribeState('s', '67', function (value) { self.dmxfb[64]['background-color'] = value; }); const sig68SubKey = CrComLib.subscribeState('s', '68', function (value) { self.dmxfb[65]['background-color'] = value; }); const sig69SubKey = CrComLib.subscribeState('s', '69', function (value) { self.dmxfb[66]['background-color'] = value; }); const sig70SubKey = CrComLib.subscribeState('s', '70', function (value) { self.dmxfb[67]['background-color'] = value; }); const sig71SubKey = CrComLib.subscribeState('s', '71', function (value) { self.dmxfb[68]['background-color'] = value; }); const sig72SubKey = CrComLib.subscribeState('s', '72', function (value) { self.dmxfb[69]['background-color'] = value; }); const sig73SubKey = CrComLib.subscribeState('s', '73', function (value) { self.dmxfb[70]['background-color'] = value; }); const sig74SubKey = CrComLib.subscribeState('s', '74', function (value) { self.dmxfb[71]['background-color'] = value; }); const sig75SubKey = CrComLib.subscribeState('s', '75', function (value) { self.dmxfb[72]['background-color'] = value; }); const sig76SubKey = CrComLib.subscribeState('s', '76', function (value) { self.dmxfb[73]['background-color'] = value; }); const sig77SubKey = CrComLib.subscribeState('s', '77', function (value) { self.dmxfb[74]['background-color'] = value; }); const sig78SubKey = CrComLib.subscribeState('s', '78', function (value) { self.dmxfb[75]['background-color'] = value; }); const sig79SubKey = CrComLib.subscribeState('s', '79', function (value) { self.dmxfb[76]['background-color'] = value; }); const sig80SubKey = CrComLib.subscribeState('s', '80', function (value) { self.dmxfb[77]['background-color'] = value; }); const sig81SubKey = CrComLib.subscribeState('s', '81', function (value) { self.dmxfb[78]['background-color'] = value; }); const sig82SubKey = CrComLib.subscribeState('s', '82', function (value) { self.dmxfb[79]['background-color'] = value; }); const sig83SubKey = CrComLib.subscribeState('s', '83', function (value) { self.dmxfb[80]['background-color'] = value; }); const sig84SubKey = CrComLib.subscribeState('s', '84', function (value) { self.dmxfb[81]['background-color'] = value; }); const sig85SubKey = CrComLib.subscribeState('s', '85', function (value) { self.dmxfb[82]['background-color'] = value; }); const sig86SubKey = CrComLib.subscribeState('s', '86', function (value) { self.dmxfb[83]['background-color'] = value; }); const sig87SubKey = CrComLib.subscribeState('s', '87', function (value) { self.dmxfb[84]['background-color'] = value; }); const sig88SubKey = CrComLib.subscribeState('s', '88', function (value) { self.dmxfb[85]['background-color'] = value; }); const sig89SubKey = CrComLib.subscribeState('s', '89', function (value) { self.dmxfb[86]['background-color'] = value; }); const sig90SubKey = CrComLib.subscribeState('s', '90', function (value) { self.dmxfb[87]['background-color'] = value; }); const sig91SubKey = CrComLib.subscribeState('s', '91', function (value) { self.dmxfb[88]['background-color'] = value; }); const sig92SubKey = CrComLib.subscribeState('s', '92', function (value) { self.dmxfb[89]['background-color'] = value; }); const sig93SubKey = CrComLib.subscribeState('s', '93', function (value) { self.dmxfb[90]['background-color'] = value; }); const sig94SubKey = CrComLib.subscribeState('s', '94', function (value) { self.dmxfb[91]['background-color'] = value; }); const sig95SubKey = CrComLib.subscribeState('s', '95', function (value) { self.dmxfb[92]['background-color'] = value; }); const sig96SubKey = CrComLib.subscribeState('s', '96', function (value) { self.dmxfb[93]['background-color'] = value; }); const sig97SubKey = CrComLib.subscribeState('s', '97', function (value) { self.dmxfb[94]['background-color'] = value; }); const sig98SubKey = CrComLib.subscribeState('s', '98', function (value) { self.dmxfb[95]['background-color'] = value; }); const sig99SubKey = CrComLib.subscribeState('s', '99', function (value) { self.dmxfb[96]['background-color'] = value; }); const sig100SubKey = CrComLib.subscribeState('s', '100', function (value) { self.dmxfb[97]['background-color'] = value; }); const sig101SubKey = CrComLib.subscribeState('s', '101', function (value) { self.dmxfb[98]['background-color'] = value; }); const sig102SubKey = CrComLib.subscribeState('s', '102', function (value) { self.dmxfb[99]['background-color'] = value; }); const sig103SubKey = CrComLib.subscribeState('s', '103', function (value) { self.dmxfb[100]['background-color'] = value; }); const sig104SubKey = CrComLib.subscribeState('s', '104', function (value) { self.dmxfb[101]['background-color'] = value; }); const sig105SubKey = CrComLib.subscribeState('s', '105', function (value) { self.dmxfb[102]['background-color'] = value; }); const sig106SubKey = CrComLib.subscribeState('s', '106', function (value) { self.dmxfb[103]['background-color'] = value; }); const sig107SubKey = CrComLib.subscribeState('s', '107', function (value) { self.dmxfb[104]['background-color'] = value; }); const sig108SubKey = CrComLib.subscribeState('s', '108', function (value) { self.dmxfb[105]['background-color'] = value; }); const sig109SubKey = CrComLib.subscribeState('s', '109', function (value) { self.dmxfb[106]['background-color'] = value; }); const sig110SubKey = CrComLib.subscribeState('s', '110', function (value) { self.dmxfb[107]['background-color'] = value; }); const sig111SubKey = CrComLib.subscribeState('s', '111', function (value) { self.dmxfb[108]['background-color'] = value; }); const sig112SubKey = CrComLib.subscribeState('s', '112', function (value) { self.dmxfb[109]['background-color'] = value; }); const sig113SubKey = CrComLib.subscribeState('s', '113', function (value) { self.dmxfb[110]['background-color'] = value; }); const sig114SubKey = CrComLib.subscribeState('s', '114', function (value) { self.dmxfb[111]['background-color'] = value; }); const sig115SubKey = CrComLib.subscribeState('s', '115', function (value) { self.dmxfb[112]['background-color'] = value; }); const sig116SubKey = CrComLib.subscribeState('s', '116', function (value) { self.dmxfb[113]['background-color'] = value; }); const sig117SubKey = CrComLib.subscribeState('s', '117', function (value) { self.dmxfb[114]['background-color'] = value; }); const sig118SubKey = CrComLib.subscribeState('s', '118', function (value) { self.dmxfb[115]['background-color'] = value; }); const sig119SubKey = CrComLib.subscribeState('s', '119', function (value) { self.dmxfb[116]['background-color'] = value; }); const sig120SubKey = CrComLib.subscribeState('s', '120', function (value) { self.dmxfb[117]['background-color'] = value; }); const sig121SubKey = CrComLib.subscribeState('s', '121', function (value) { self.dmxfb[118]['background-color'] = value; }); const sig122SubKey = CrComLib.subscribeState('s', '122', function (value) { self.dmxfb[119]['background-color'] = value; });


    ////////timeout for refreshing CrCom subscribeState
    setInterval(function () { }, 1000);




  }




  ////////////DMX Mat dialog pop up

  DMXcall(id: number) {
    const dialogRef = this.dialog.open(DmxpopComponent, {
      width: '80vw',
      data: id,
    });
    let temp: number;
    id = id - 1;
    temp = id * 10 + 3;
    let temp2: string;
    temp2 = temp.toString();
    CrComLib.publishEvent('b', temp2, true);
    CrComLib.publishEvent('b', temp2, false);


  }
}

