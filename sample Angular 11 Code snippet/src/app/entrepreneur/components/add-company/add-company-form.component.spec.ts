import { ComponentFixture, TestBed } from '@angular/core/testing';
import { AddCompanyFormComponent } from './add-company-form.component';

describe('ProfileFormComponent', () => {
  let component: AddCompanyFormComponent;
  let fixture: ComponentFixture<AddCompanyFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddCompanyFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddCompanyFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
