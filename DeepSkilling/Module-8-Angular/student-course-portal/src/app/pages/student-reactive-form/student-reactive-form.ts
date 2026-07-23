import { Component } from '@angular/core';
import {
  FormControl,
  FormGroup,
  ReactiveFormsModule,
  Validators
} from '@angular/forms';

@Component({
  selector: 'app-student-reactive-form',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './student-reactive-form.html',
  styleUrl: './student-reactive-form.css'
})
export class StudentReactiveForm {

  studentForm = new FormGroup({

    name: new FormControl('', [
      Validators.required,
      Validators.minLength(3)
    ]),

    email: new FormControl('', [
      Validators.required,
      Validators.email
    ]),

    course: new FormControl('', [
      Validators.required
    ])

  });

  onSubmit() {

    if (this.studentForm.valid) {

      console.log(this.studentForm.value);

      alert("Registration Successful!");

    }

  }

}