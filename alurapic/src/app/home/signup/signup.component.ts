import { PlatformDetectorService } from './../../core/plataform-detector/platform-detector.service';
import { Router } from '@angular/router';
import { SignUpService } from './signup.service';
import { User } from './../../core/user/user';
import { UserNotTakenValidatorService } from './user-not-taken.validator.service';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { lowerCaseValidator } from 'src/app/shared/validators/lowercase.validator';

@Component({
  templateUrl: './signup.component.html',
  providers: [ UserNotTakenValidatorService ]
})
export class SignUpComponent implements OnInit{

    signupForm: FormGroup;
    @ViewChild('inputemail') inputEmail: ElementRef<HTMLInputElement>

    constructor(private formBuilder: FormBuilder,
      private userNotTakenValidatorService: UserNotTakenValidatorService,
      private signupService: SignUpService,
      private router: Router,
      private platformDetector: PlatformDetectorService){

    }
  ngOnInit(): void {
    this.signupForm = this.formBuilder.group({
      email: ['', [
        Validators.required,
        Validators.email,
      ]],
      userName: ['', [
        Validators.required,
        Validators.minLength(2),
        Validators.maxLength(30),
        lowerCaseValidator,
      ],
        this.userNotTakenValidatorService.checkUserNameTaken()
    ],
      fullName: ['', [
        Validators.required,
        Validators.minLength(2),
        Validators.maxLength(40)
      ]],
      password: ['', [
        Validators.required,
        Validators.minLength(8),
        Validators.maxLength(18)
      ]]
    });
    this.platformDetector.isPlatformBrowser() &&
    this.inputEmail.nativeElement.focus();
  }

  signup(){
    const newUser = this.signupForm.getRawValue() as User;
    this.signupService.signup(newUser).subscribe(()=>{
      this.router.navigate(['']);
    })
  }

}
