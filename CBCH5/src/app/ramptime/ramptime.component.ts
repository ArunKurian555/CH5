import { Component, OnInit } from '@angular/core';



declare var CrComLib: any;
@Component({
  selector: 'app-ramptime',
  templateUrl: './ramptime.component.html',
  styleUrls: ['./ramptime.component.scss']
})
export class RamptimeComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  click1()
  {
  CrComLib.publishEvent('b', 1205, true);
  CrComLib.publishEvent('b', 1205, false);
  
  }
  
click2()
{
CrComLib.publishEvent('b', 1206, true);
CrComLib.publishEvent('b', 1206, false);

}
}