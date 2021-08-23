import { Component, OnInit } from '@angular/core';
import { ChRouteService } from 'src/service/ch-route.service';
import { CdkDragEnd } from '@angular/cdk/drag-drop';
import { MatDialog } from '@angular/material/dialog';
import { FpzonecontrolComponent } from '../fpzonecontrol/fpzonecontrol.component';

declare var CrComLib: any;

@Component({
  selector: 'app-view7',
  templateUrl: './view7.component.html',
  styleUrls: ['./view7.component.scss']
})
export class View7Component implements OnInit {
  dragPosition = { x: 0, y: 0 };
  positionarray = [];
  constructor(public rout: ChRouteService, public dialog: MatDialog) { }
  items = [1, 2, 3, 4, 5, 6];

  ngOnInit(): void {
    let self = this;

    setTimeout(() => {


      const areasize = CrComLib.getState('n', 'Area.Size', true);

      this.positionarray = [];
      this.items = [];
      for (let index = 0; index < areasize; index++) {
        this.positionarray.push(this.dragPosition);
        this.items.push(index);
      }


      const sigValuex1 = CrComLib.getState('s', '200', true); const sigValuex2 = CrComLib.getState('s', '201', true); const sigValuex3 = CrComLib.getState('s', '202', true); const sigValuex4 = CrComLib.getState('s', '203', true); const sigValuex5 = CrComLib.getState('s', '204', true); const sigValuex6 = CrComLib.getState('s', '205', true); const sigValuex7 = CrComLib.getState('s', '206', true); const sigValuex8 = CrComLib.getState('s', '207', true); const sigValuex9 = CrComLib.getState('s', '208', true); const sigValuex10 = CrComLib.getState('s', '209', true); const sigValuex11 = CrComLib.getState('s', '210', true); const sigValuex12 = CrComLib.getState('s', '211', true); const sigValuex13 = CrComLib.getState('s', '212', true); const sigValuex14 = CrComLib.getState('s', '213', true); const sigValuex15 = CrComLib.getState('s', '214', true); const sigValuex16 = CrComLib.getState('s', '215', true); const sigValuex17 = CrComLib.getState('s', '216', true); const sigValuex18 = CrComLib.getState('s', '217', true); const sigValuex19 = CrComLib.getState('s', '218', true); const sigValuex20 = CrComLib.getState('s', '219', true); const sigValuex21 = CrComLib.getState('s', '220', true); const sigValuex22 = CrComLib.getState('s', '221', true); const sigValuex23 = CrComLib.getState('s', '222', true); const sigValuex24 = CrComLib.getState('s', '223', true); const sigValuex25 = CrComLib.getState('s', '224', true); const sigValuex26 = CrComLib.getState('s', '225', true); const sigValuex27 = CrComLib.getState('s', '226', true); const sigValuex28 = CrComLib.getState('s', '227', true); const sigValuex29 = CrComLib.getState('s', '228', true); const sigValuex30 = CrComLib.getState('s', '229', true); const sigValuex31 = CrComLib.getState('s', '230', true); const sigValuex32 = CrComLib.getState('s', '231', true); const sigValuex33 = CrComLib.getState('s', '232', true); const sigValuex34 = CrComLib.getState('s', '233', true); const sigValuex35 = CrComLib.getState('s', '234', true); const sigValuex36 = CrComLib.getState('s', '235', true); const sigValuex37 = CrComLib.getState('s', '236', true); const sigValuex38 = CrComLib.getState('s', '237', true); const sigValuex39 = CrComLib.getState('s', '238', true); const sigValuex40 = CrComLib.getState('s', '239', true); const sigValuex41 = CrComLib.getState('s', '240', true); const sigValuex42 = CrComLib.getState('s', '241', true); const sigValuex43 = CrComLib.getState('s', '242', true); const sigValuex44 = CrComLib.getState('s', '243', true); const sigValuex45 = CrComLib.getState('s', '244', true); const sigValuex46 = CrComLib.getState('s', '245', true); const sigValuex47 = CrComLib.getState('s', '246', true); const sigValuex48 = CrComLib.getState('s', '247', true); const sigValuex49 = CrComLib.getState('s', '248', true); const sigValuex50 = CrComLib.getState('s', '249', true);


      const sigValuey1 = CrComLib.getState('s', '300', true); const sigValuey2 = CrComLib.getState('s', '301', true); const sigValuey3 = CrComLib.getState('s', '302', true); const sigValuey4 = CrComLib.getState('s', '303', true); const sigValuey5 = CrComLib.getState('s', '304', true); const sigValuey6 = CrComLib.getState('s', '305', true); const sigValuey7 = CrComLib.getState('s', '306', true); const sigValuey8 = CrComLib.getState('s', '307', true); const sigValuey9 = CrComLib.getState('s', '308', true); const sigValuey10 = CrComLib.getState('s', '309', true); const sigValuey11 = CrComLib.getState('s', '310', true); const sigValuey12 = CrComLib.getState('s', '311', true); const sigValuey13 = CrComLib.getState('s', '312', true); const sigValuey14 = CrComLib.getState('s', '313', true); const sigValuey15 = CrComLib.getState('s', '314', true); const sigValuey16 = CrComLib.getState('s', '315', true); const sigValuey17 = CrComLib.getState('s', '316', true); const sigValuey18 = CrComLib.getState('s', '317', true); const sigValuey19 = CrComLib.getState('s', '318', true); const sigValuey20 = CrComLib.getState('s', '319', true); const sigValuey21 = CrComLib.getState('s', '320', true); const sigValuey22 = CrComLib.getState('s', '321', true); const sigValuey23 = CrComLib.getState('s', '322', true); const sigValuey24 = CrComLib.getState('s', '323', true); const sigValuey25 = CrComLib.getState('s', '324', true); const sigValuey26 = CrComLib.getState('s', '325', true); const sigValuey27 = CrComLib.getState('s', '326', true); const sigValuey28 = CrComLib.getState('s', '327', true); const sigValuey29 = CrComLib.getState('s', '328', true); const sigValuey30 = CrComLib.getState('s', '329', true); const sigValuey31 = CrComLib.getState('s', '330', true); const sigValuey32 = CrComLib.getState('s', '331', true); const sigValuey33 = CrComLib.getState('s', '332', true); const sigValuey34 = CrComLib.getState('s', '333', true); const sigValuey35 = CrComLib.getState('s', '334', true); const sigValuey36 = CrComLib.getState('s', '335', true); const sigValuey37 = CrComLib.getState('s', '336', true); const sigValuey38 = CrComLib.getState('s', '337', true); const sigValuey39 = CrComLib.getState('s', '338', true); const sigValuey40 = CrComLib.getState('s', '339', true); const sigValuey41 = CrComLib.getState('s', '340', true); const sigValuey42 = CrComLib.getState('s', '341', true); const sigValuey43 = CrComLib.getState('s', '342', true); const sigValuey44 = CrComLib.getState('s', '343', true); const sigValuey45 = CrComLib.getState('s', '344', true); const sigValuey46 = CrComLib.getState('s', '345', true); const sigValuey47 = CrComLib.getState('s', '346', true); const sigValuey48 = CrComLib.getState('s', '347', true); const sigValuey49 = CrComLib.getState('s', '348', true); const sigValuey50 = CrComLib.getState('s', '349', true);

      this.positionarray[1] = { x: parseFloat(sigValuex1), y: parseFloat(sigValuey1) };
      this.positionarray[2] = { x: parseFloat(sigValuex2), y: parseFloat(sigValuey2) };
      this.positionarray[3] = { x: parseFloat(sigValuex3), y: parseFloat(sigValuey3) };
      this.positionarray[4] = { x: parseFloat(sigValuex4), y: parseFloat(sigValuey4) };
      this.positionarray[5] = { x: parseFloat(sigValuex5), y: parseFloat(sigValuey5) };
      this.positionarray[6] = { x: parseFloat(sigValuex6), y: parseFloat(sigValuey6) };
      this.positionarray[7] = { x: parseFloat(sigValuex7), y: parseFloat(sigValuey7) };
      this.positionarray[8] = { x: parseFloat(sigValuex8), y: parseFloat(sigValuey8) };
      this.positionarray[9] = { x: parseFloat(sigValuex9), y: parseFloat(sigValuey9) };
      this.positionarray[10] = { x: parseFloat(sigValuex10), y: parseFloat(sigValuey10) };
      this.positionarray[11] = { x: parseFloat(sigValuex11), y: parseFloat(sigValuey11) };
      this.positionarray[12] = { x: parseFloat(sigValuex12), y: parseFloat(sigValuey12) };
      this.positionarray[13] = { x: parseFloat(sigValuex13), y: parseFloat(sigValuey13) };
      this.positionarray[14] = { x: parseFloat(sigValuex14), y: parseFloat(sigValuey14) };
      this.positionarray[15] = { x: parseFloat(sigValuex15), y: parseFloat(sigValuey15) };
      this.positionarray[16] = { x: parseFloat(sigValuex16), y: parseFloat(sigValuey16) };
      this.positionarray[17] = { x: parseFloat(sigValuex17), y: parseFloat(sigValuey17) };
      this.positionarray[18] = { x: parseFloat(sigValuex18), y: parseFloat(sigValuey18) };
      this.positionarray[19] = { x: parseFloat(sigValuex19), y: parseFloat(sigValuey19) };
      this.positionarray[20] = { x: parseFloat(sigValuex20), y: parseFloat(sigValuey20) };
      this.positionarray[21] = { x: parseFloat(sigValuex21), y: parseFloat(sigValuey21) };
      this.positionarray[22] = { x: parseFloat(sigValuex22), y: parseFloat(sigValuey22) };
      this.positionarray[23] = { x: parseFloat(sigValuex23), y: parseFloat(sigValuey23) };
      this.positionarray[24] = { x: parseFloat(sigValuex24), y: parseFloat(sigValuey24) };
      this.positionarray[25] = { x: parseFloat(sigValuex25), y: parseFloat(sigValuey25) };
      this.positionarray[26] = { x: parseFloat(sigValuex26), y: parseFloat(sigValuey26) };
      this.positionarray[27] = { x: parseFloat(sigValuex27), y: parseFloat(sigValuey27) };
      this.positionarray[28] = { x: parseFloat(sigValuex28), y: parseFloat(sigValuey28) };
      this.positionarray[29] = { x: parseFloat(sigValuex29), y: parseFloat(sigValuey29) };
      this.positionarray[30] = { x: parseFloat(sigValuex30), y: parseFloat(sigValuey30) };
      this.positionarray[31] = { x: parseFloat(sigValuex31), y: parseFloat(sigValuey31) };
      this.positionarray[32] = { x: parseFloat(sigValuex32), y: parseFloat(sigValuey32) };
      this.positionarray[33] = { x: parseFloat(sigValuex33), y: parseFloat(sigValuey33) };
      this.positionarray[34] = { x: parseFloat(sigValuex34), y: parseFloat(sigValuey34) };
      this.positionarray[35] = { x: parseFloat(sigValuex35), y: parseFloat(sigValuey35) };
      this.positionarray[36] = { x: parseFloat(sigValuex36), y: parseFloat(sigValuey36) };
      this.positionarray[37] = { x: parseFloat(sigValuex37), y: parseFloat(sigValuey37) };
      this.positionarray[38] = { x: parseFloat(sigValuex38), y: parseFloat(sigValuey38) };
      this.positionarray[39] = { x: parseFloat(sigValuex39), y: parseFloat(sigValuey39) };
      this.positionarray[40] = { x: parseFloat(sigValuex40), y: parseFloat(sigValuey40) };
      this.positionarray[41] = { x: parseFloat(sigValuex41), y: parseFloat(sigValuey41) };
      this.positionarray[42] = { x: parseFloat(sigValuex42), y: parseFloat(sigValuey42) };
      this.positionarray[43] = { x: parseFloat(sigValuex43), y: parseFloat(sigValuey43) };
      this.positionarray[44] = { x: parseFloat(sigValuex44), y: parseFloat(sigValuey44) };
      this.positionarray[45] = { x: parseFloat(sigValuex45), y: parseFloat(sigValuey45) };
      this.positionarray[46] = { x: parseFloat(sigValuex46), y: parseFloat(sigValuey46) };
      this.positionarray[47] = { x: parseFloat(sigValuex47), y: parseFloat(sigValuey47) };
      this.positionarray[48] = { x: parseFloat(sigValuex48), y: parseFloat(sigValuey48) };
      this.positionarray[49] = { x: parseFloat(sigValuex49), y: parseFloat(sigValuey49) };
      this.positionarray[50] = { x: parseFloat(sigValuex50), y: parseFloat(sigValuey50) };





    }, 60000);
    /*     this.positionarray = JSON.parse(localStorage.getItem("savedData"))[0]; */

  }
  onclick() {
    this.rout.active = 5;


    const areasize = CrComLib.getState('n', 'Area.Size', true);

    this.positionarray = [];
    this.items = []; for (let index = 0; index < areasize; index++) {
      this.positionarray.push(this.dragPosition);
      this.items.push(index);
    }



    const sigValuex1 = CrComLib.getState('s', '200', true); const sigValuex2 = CrComLib.getState('s', '201', true); const sigValuex3 = CrComLib.getState('s', '202', true); const sigValuex4 = CrComLib.getState('s', '203', true); const sigValuex5 = CrComLib.getState('s', '204', true); const sigValuex6 = CrComLib.getState('s', '205', true); const sigValuex7 = CrComLib.getState('s', '206', true); const sigValuex8 = CrComLib.getState('s', '207', true); const sigValuex9 = CrComLib.getState('s', '208', true); const sigValuex10 = CrComLib.getState('s', '209', true); const sigValuex11 = CrComLib.getState('s', '210', true); const sigValuex12 = CrComLib.getState('s', '211', true); const sigValuex13 = CrComLib.getState('s', '212', true); const sigValuex14 = CrComLib.getState('s', '213', true); const sigValuex15 = CrComLib.getState('s', '214', true); const sigValuex16 = CrComLib.getState('s', '215', true); const sigValuex17 = CrComLib.getState('s', '216', true); const sigValuex18 = CrComLib.getState('s', '217', true); const sigValuex19 = CrComLib.getState('s', '218', true); const sigValuex20 = CrComLib.getState('s', '219', true); const sigValuex21 = CrComLib.getState('s', '220', true); const sigValuex22 = CrComLib.getState('s', '221', true); const sigValuex23 = CrComLib.getState('s', '222', true); const sigValuex24 = CrComLib.getState('s', '223', true); const sigValuex25 = CrComLib.getState('s', '224', true); const sigValuex26 = CrComLib.getState('s', '225', true); const sigValuex27 = CrComLib.getState('s', '226', true); const sigValuex28 = CrComLib.getState('s', '227', true); const sigValuex29 = CrComLib.getState('s', '228', true); const sigValuex30 = CrComLib.getState('s', '229', true); const sigValuex31 = CrComLib.getState('s', '230', true); const sigValuex32 = CrComLib.getState('s', '231', true); const sigValuex33 = CrComLib.getState('s', '232', true); const sigValuex34 = CrComLib.getState('s', '233', true); const sigValuex35 = CrComLib.getState('s', '234', true); const sigValuex36 = CrComLib.getState('s', '235', true); const sigValuex37 = CrComLib.getState('s', '236', true); const sigValuex38 = CrComLib.getState('s', '237', true); const sigValuex39 = CrComLib.getState('s', '238', true); const sigValuex40 = CrComLib.getState('s', '239', true); const sigValuex41 = CrComLib.getState('s', '240', true); const sigValuex42 = CrComLib.getState('s', '241', true); const sigValuex43 = CrComLib.getState('s', '242', true); const sigValuex44 = CrComLib.getState('s', '243', true); const sigValuex45 = CrComLib.getState('s', '244', true); const sigValuex46 = CrComLib.getState('s', '245', true); const sigValuex47 = CrComLib.getState('s', '246', true); const sigValuex48 = CrComLib.getState('s', '247', true); const sigValuex49 = CrComLib.getState('s', '248', true); const sigValuex50 = CrComLib.getState('s', '249', true);


    const sigValuey1 = CrComLib.getState('s', '300', true); const sigValuey2 = CrComLib.getState('s', '301', true); const sigValuey3 = CrComLib.getState('s', '302', true); const sigValuey4 = CrComLib.getState('s', '303', true); const sigValuey5 = CrComLib.getState('s', '304', true); const sigValuey6 = CrComLib.getState('s', '305', true); const sigValuey7 = CrComLib.getState('s', '306', true); const sigValuey8 = CrComLib.getState('s', '307', true); const sigValuey9 = CrComLib.getState('s', '308', true); const sigValuey10 = CrComLib.getState('s', '309', true); const sigValuey11 = CrComLib.getState('s', '310', true); const sigValuey12 = CrComLib.getState('s', '311', true); const sigValuey13 = CrComLib.getState('s', '312', true); const sigValuey14 = CrComLib.getState('s', '313', true); const sigValuey15 = CrComLib.getState('s', '314', true); const sigValuey16 = CrComLib.getState('s', '315', true); const sigValuey17 = CrComLib.getState('s', '316', true); const sigValuey18 = CrComLib.getState('s', '317', true); const sigValuey19 = CrComLib.getState('s', '318', true); const sigValuey20 = CrComLib.getState('s', '319', true); const sigValuey21 = CrComLib.getState('s', '320', true); const sigValuey22 = CrComLib.getState('s', '321', true); const sigValuey23 = CrComLib.getState('s', '322', true); const sigValuey24 = CrComLib.getState('s', '323', true); const sigValuey25 = CrComLib.getState('s', '324', true); const sigValuey26 = CrComLib.getState('s', '325', true); const sigValuey27 = CrComLib.getState('s', '326', true); const sigValuey28 = CrComLib.getState('s', '327', true); const sigValuey29 = CrComLib.getState('s', '328', true); const sigValuey30 = CrComLib.getState('s', '329', true); const sigValuey31 = CrComLib.getState('s', '330', true); const sigValuey32 = CrComLib.getState('s', '331', true); const sigValuey33 = CrComLib.getState('s', '332', true); const sigValuey34 = CrComLib.getState('s', '333', true); const sigValuey35 = CrComLib.getState('s', '334', true); const sigValuey36 = CrComLib.getState('s', '335', true); const sigValuey37 = CrComLib.getState('s', '336', true); const sigValuey38 = CrComLib.getState('s', '337', true); const sigValuey39 = CrComLib.getState('s', '338', true); const sigValuey40 = CrComLib.getState('s', '339', true); const sigValuey41 = CrComLib.getState('s', '340', true); const sigValuey42 = CrComLib.getState('s', '341', true); const sigValuey43 = CrComLib.getState('s', '342', true); const sigValuey44 = CrComLib.getState('s', '343', true); const sigValuey45 = CrComLib.getState('s', '344', true); const sigValuey46 = CrComLib.getState('s', '345', true); const sigValuey47 = CrComLib.getState('s', '346', true); const sigValuey48 = CrComLib.getState('s', '347', true); const sigValuey49 = CrComLib.getState('s', '348', true); const sigValuey50 = CrComLib.getState('s', '349', true);

    this.positionarray[1] = { x: parseFloat(sigValuex1), y: parseFloat(sigValuey1) };
    this.positionarray[2] = { x: parseFloat(sigValuex2), y: parseFloat(sigValuey2) };
    this.positionarray[3] = { x: parseFloat(sigValuex3), y: parseFloat(sigValuey3) };
    this.positionarray[4] = { x: parseFloat(sigValuex4), y: parseFloat(sigValuey4) };
    this.positionarray[5] = { x: parseFloat(sigValuex5), y: parseFloat(sigValuey5) };
    this.positionarray[6] = { x: parseFloat(sigValuex6), y: parseFloat(sigValuey6) };
    this.positionarray[7] = { x: parseFloat(sigValuex7), y: parseFloat(sigValuey7) };
    this.positionarray[8] = { x: parseFloat(sigValuex8), y: parseFloat(sigValuey8) };
    this.positionarray[9] = { x: parseFloat(sigValuex9), y: parseFloat(sigValuey9) };
    this.positionarray[10] = { x: parseFloat(sigValuex10), y: parseFloat(sigValuey10) };
    this.positionarray[11] = { x: parseFloat(sigValuex11), y: parseFloat(sigValuey11) };
    this.positionarray[12] = { x: parseFloat(sigValuex12), y: parseFloat(sigValuey12) };
    this.positionarray[13] = { x: parseFloat(sigValuex13), y: parseFloat(sigValuey13) };
    this.positionarray[14] = { x: parseFloat(sigValuex14), y: parseFloat(sigValuey14) };
    this.positionarray[15] = { x: parseFloat(sigValuex15), y: parseFloat(sigValuey15) };
    this.positionarray[16] = { x: parseFloat(sigValuex16), y: parseFloat(sigValuey16) };
    this.positionarray[17] = { x: parseFloat(sigValuex17), y: parseFloat(sigValuey17) };
    this.positionarray[18] = { x: parseFloat(sigValuex18), y: parseFloat(sigValuey18) };
    this.positionarray[19] = { x: parseFloat(sigValuex19), y: parseFloat(sigValuey19) };
    this.positionarray[20] = { x: parseFloat(sigValuex20), y: parseFloat(sigValuey20) };
    this.positionarray[21] = { x: parseFloat(sigValuex21), y: parseFloat(sigValuey21) };
    this.positionarray[22] = { x: parseFloat(sigValuex22), y: parseFloat(sigValuey22) };
    this.positionarray[23] = { x: parseFloat(sigValuex23), y: parseFloat(sigValuey23) };
    this.positionarray[24] = { x: parseFloat(sigValuex24), y: parseFloat(sigValuey24) };
    this.positionarray[25] = { x: parseFloat(sigValuex25), y: parseFloat(sigValuey25) };
    this.positionarray[26] = { x: parseFloat(sigValuex26), y: parseFloat(sigValuey26) };
    this.positionarray[27] = { x: parseFloat(sigValuex27), y: parseFloat(sigValuey27) };
    this.positionarray[28] = { x: parseFloat(sigValuex28), y: parseFloat(sigValuey28) };
    this.positionarray[29] = { x: parseFloat(sigValuex29), y: parseFloat(sigValuey29) };
    this.positionarray[30] = { x: parseFloat(sigValuex30), y: parseFloat(sigValuey30) };
    this.positionarray[31] = { x: parseFloat(sigValuex31), y: parseFloat(sigValuey31) };
    this.positionarray[32] = { x: parseFloat(sigValuex32), y: parseFloat(sigValuey32) };
    this.positionarray[33] = { x: parseFloat(sigValuex33), y: parseFloat(sigValuey33) };
    this.positionarray[34] = { x: parseFloat(sigValuex34), y: parseFloat(sigValuey34) };
    this.positionarray[35] = { x: parseFloat(sigValuex35), y: parseFloat(sigValuey35) };
    this.positionarray[36] = { x: parseFloat(sigValuex36), y: parseFloat(sigValuey36) };
    this.positionarray[37] = { x: parseFloat(sigValuex37), y: parseFloat(sigValuey37) };
    this.positionarray[38] = { x: parseFloat(sigValuex38), y: parseFloat(sigValuey38) };
    this.positionarray[39] = { x: parseFloat(sigValuex39), y: parseFloat(sigValuey39) };
    this.positionarray[40] = { x: parseFloat(sigValuex40), y: parseFloat(sigValuey40) };
    this.positionarray[41] = { x: parseFloat(sigValuex41), y: parseFloat(sigValuey41) };
    this.positionarray[42] = { x: parseFloat(sigValuex42), y: parseFloat(sigValuey42) };
    this.positionarray[43] = { x: parseFloat(sigValuex43), y: parseFloat(sigValuey43) };
    this.positionarray[44] = { x: parseFloat(sigValuex44), y: parseFloat(sigValuey44) };
    this.positionarray[45] = { x: parseFloat(sigValuex45), y: parseFloat(sigValuey45) };
    this.positionarray[46] = { x: parseFloat(sigValuex46), y: parseFloat(sigValuey46) };
    this.positionarray[47] = { x: parseFloat(sigValuex47), y: parseFloat(sigValuey47) };
    this.positionarray[48] = { x: parseFloat(sigValuex48), y: parseFloat(sigValuey48) };
    this.positionarray[49] = { x: parseFloat(sigValuex49), y: parseFloat(sigValuey49) };
    this.positionarray[50] = { x: parseFloat(sigValuex50), y: parseFloat(sigValuey50) };



    /* 
        const sigValuex1 = CrComLib.getState('s', '200', true);
        const sigValuey1 = CrComLib.getState('s', '300', true);
     */


  }
  controlpop(i) {
    CrComLib.publishEvent('b', "Area.AreaSelect" + i, true);
    CrComLib.publishEvent('b', "Area.AreaSelect" + i, false);
    
    this.rout.active = 0;

    // const dialogRef = this.dialog.open(FpzonecontrolComponent, {
    // }); disable pop up
  }

  save() {

    CrComLib.publishEvent('b', "1204", true);
    CrComLib.publishEvent('b', "1204", false);
  }



  public onDragEnded(event: CdkDragEnd, a): void {
    this.positionarray[a + 1] = event.source.getFreeDragPosition();
    let x = this.positionarray[a + 1].x.toFixed(1);
    let y = this.positionarray[a + 1].y.toFixed(1);
    let xc = 200 + a;
    let xa = xc.toString();
    let yc = 300 + a;
    let ya = yc.toString();
    CrComLib.publishEvent('s', xa, x);
    CrComLib.publishEvent('s', ya, y);
    /* 
        localStorage.setItem("savedData", JSON.stringify([this.positionarray])); */
  }
}
