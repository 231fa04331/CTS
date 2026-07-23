import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-student-dashboard',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './student-dashboard.html',
  styleUrl: './student-dashboard.css'
})
export class StudentDashboard implements OnInit {

  studentName = "Sai Charan";
  course = "Angular";
  marks = 95;

  ngOnInit(): void {
    console.log("Dashboard Loaded Successfully");
  }

  changeCourse() {
    this.course = "Angular Advanced";
  }
}