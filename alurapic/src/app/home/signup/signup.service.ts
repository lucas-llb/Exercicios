import { User } from './../../core/user/user';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

const API_URL = "http://localhost:3000"
@Injectable()
export class SignUpService {

    constructor(private http: HttpClient){}

    checkUserNameTaken(userName: string){
      return this.http.get(API_URL + '/user/exists/' + userName);
    }

    signup(user: User){
      return this.http.post(API_URL + '/user/signup', user);
    }
}
