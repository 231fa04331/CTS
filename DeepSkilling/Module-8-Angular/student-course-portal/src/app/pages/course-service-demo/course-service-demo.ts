import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CourseService } from '../../services/course';

@Component({
  selector: 'app-course-service-demo',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './course-service-demo.html',
  styleUrl: './course-service-demo.css'
})
export class CourseServiceDemo {

  courses: string[] = [];

  constructor(private courseService: CourseService) {
    this.courses = this.courseService.getCourses();
  }

}