import { Component, OnInit } from "@angular/core"
import { ActivatedRoute, Router } from "@angular/router";
import { User } from "../../models/user";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})

export class LoginComponent implements OnInit {
  public user;
  public returnUrl: string;
  //public authentifiedUser: boolean;

  constructor(private router: Router, private activatedRouter: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.user = new User();
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
  }

  enter(): void {
    ///USER VALIDATION - PRE-DEFINED User and Password
    ///Not Secure - Saved at the browser
    if (this.user.email == "theomitchell@gmail.com" && this.user.password
      == "123456") {
      //Store email & password at Local Storage and send to Homepage
      sessionStorage.setItem("user-authenticated", "1");       //Store locally while using the system
      this.router.navigate([this.returnUrl]);        //Send to Homepage
    }
    ///USER VALIDATION - Using User and Password from a DB
    //TBD!!!

  }
}
