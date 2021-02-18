import { Component } from "@angular/core"

@Component({
  selector: "app-products",
  templateUrl: "./products.component.html",
  styleUrls: ["./products.component.css"]
})

export class ProductsComponent {
  
  public name: string;
  public isReadyToSale: boolean;

  public getName(): string {
    return this.name;
  }
}
