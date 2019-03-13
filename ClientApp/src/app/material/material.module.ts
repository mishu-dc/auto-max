import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatInputModule } from '@angular/material/input';
import { MatCheckboxModule } from '@angular/material/checkbox';

@NgModule({
  imports: [
    CommonModule
  ],
  exports:[
    BrowserAnimationsModule,
    MatInputModule,
    MatCheckboxModule
  ],
  declarations: []
})
export class MaterialModule { }
