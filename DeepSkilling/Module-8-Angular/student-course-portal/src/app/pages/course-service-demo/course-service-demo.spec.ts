import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CourseServiceDemo } from './course-service-demo';

describe('CourseServiceDemo', () => {
  let component: CourseServiceDemo;
  let fixture: ComponentFixture<CourseServiceDemo>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CourseServiceDemo]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CourseServiceDemo);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
