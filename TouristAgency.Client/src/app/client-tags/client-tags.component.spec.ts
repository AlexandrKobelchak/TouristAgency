import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ClientTagsComponent } from './client-tags.component';

describe('ClientTagsComponent', () => {
  let component: ClientTagsComponent;
  let fixture: ComponentFixture<ClientTagsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ClientTagsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ClientTagsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
