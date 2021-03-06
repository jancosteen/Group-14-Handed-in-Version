import { Platform } from '@ionic/angular';
import { Injectable } from '@angular/core';
import { Storage } from '@ionic/storage';
import { BehaviorSubject } from 'rxjs';
import {HttpClient} from '@angular/common/http';



const TOKEN_KEY = 'token';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  authenticationState = new BehaviorSubject(false);
  checkedInState = new BehaviorSubject(false);

  constructor(private storage: Storage, private plt: Platform, private http: HttpClient) { 
    this.plt.ready().then(() => {
      this.checkToken();
    });
  }


  checkToken() {
    this.storage.get(TOKEN_KEY).then(res => {
      if (res) {
        this.authenticationState.next(true);
      }
    })
  }

  setCheckInState(){
    this.checkedInState.next(true);
  }
 
  login() {    
    return this.storage.set(TOKEN_KEY, 'Bearer 1234567').then(() => {
      this.authenticationState.next(true);
      
    });    
  }
 
  logout() {
    return this.storage.remove(TOKEN_KEY).then(() => {
      this.authenticationState.next(false);
      this.checkedInState.next(false);
      this.storage.clear();
      localStorage.clear();
    });
  }
 
  isAuthenticated() {
    return this.authenticationState.value;
  }
}
