import { Injectable } from "@angular/core";
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from "@angular/router";

@Injectable({
  providedIn: 'root'
})

export class RouteKeeper implements CanActivate {

  constructor(private router: Router) {
  }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
    var userIsAuthenticated = sessionStorage.getItem("user-authenticated");  //Store locally from the login component

    //The User is Authenticated? 
    if (userIsAuthenticated == "1") {
      return true;
    } else {
      //Send to Authentication Page if user NOT authenticated and after Logged in send back to the tried page (e.g. Product) NOT to homepage
      this.router.navigate(['/login'], { queryParams: { returnUrl: state.url } });
      return false;
    }
  }
}
