import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-course-list-demo',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './course-list-demo.html',
  styleUrl: './course-list-demo.css'
})
export class CourseListDemo {

  showCourses = true;

  today = new Date();

  fee = 15000;

  courses = [
    'Angular',
    'React',
    'Java',
    'Python',
    'SQL'
  ];
}