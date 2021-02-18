import { Component } from "@angular/core"
import { User } from "../../models/user";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})

export class LoginComponent {
  public user;
  //public authentifiedUser: boolean;

  constructor() {
    this.user = new User();
  }

  enter(): void {
    ///USER VALIDATION
    //if (this.user.email == "theomitchell@gmail.com" && this.user.password == "123456") {
    //  this.authentifiedUser = true;
    //}
      if (this.user.email == "theomitchell@gmail.com" && this.user.password == "123456") {      
    }  
  }
}
