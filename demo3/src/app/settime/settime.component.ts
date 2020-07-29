import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-settime',
  templateUrl: './settime.component.html',
  styleUrls: ['./settime.component.scss']
})
export class SettimeComponent implements OnInit {

  hours = Array.from({ length: 12 }).map((_, i) => `${i + 1}`);
  minutes = Array.from({ length: 59 }).map((_, i) => `${i}`);

  constructor() { }

  ngOnInit(): void {
  }

}
