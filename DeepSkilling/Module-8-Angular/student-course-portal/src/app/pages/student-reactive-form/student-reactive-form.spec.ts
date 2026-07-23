import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StudentReactiveForm } from './student-reactive-form';

describe('StudentReactiveForm', () => {
  let component: StudentReactiveForm;
  let fixture: ComponentFixture<StudentReactiveForm>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [StudentReactiveForm]
    })
    .compileComponents();

    fixture = TestBed.createComponent(StudentReactiveForm);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
