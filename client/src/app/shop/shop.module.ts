import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShopComponent } from './shop.component';
import { ProductItemComponent } from './product-item/product-item.component';
import { ShareModule } from "../shared/shared.module";
import { ProductDetailsComponent } from './product-details/product-details.component';

@NgModule({
  declarations: [
    ShopComponent,
    ProductItemComponent,
    ProductDetailsComponent
  ],
  imports: [
    CommonModule,
    ShareModule
  ],
  exports: [ShopComponent]
})
export class ShopModule { }
