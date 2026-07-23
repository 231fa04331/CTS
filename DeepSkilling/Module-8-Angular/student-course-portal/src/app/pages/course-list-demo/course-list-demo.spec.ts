import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CourseListDemo } from './course-list-demo';

describe('CourseListDemo', () => {
  let component: CourseListDemo;
  let fixture: ComponentFixture<CourseListDemo>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CourseListDemo]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CourseListDemo);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
