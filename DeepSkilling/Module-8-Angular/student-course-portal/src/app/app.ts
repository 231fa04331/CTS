import { Component } from '@angular/core';
import { Header } from './components/header/header';
import { Home } from './pages/home/home';
import { StudentDashboard } from './pages/student-dashboard/student-dashboard';
import { CourseListDemo } from './pages/course-list-demo/course-list-demo';
import { StudentForm } from './pages/student-form/student-form';
import { StudentReactiveForm } from './pages/student-reactive-form/student-reactive-form';
import { CourseServiceDemo } from './pages/course-service-demo/course-service-demo';
@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    Header,
    Home,
    CourseServiceDemo
    
     
  ],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App { }