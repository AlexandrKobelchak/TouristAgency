import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ClientFindComponent } from './client-find.component';

describe('ClientFindComponent', () => {
  let component: ClientFindComponent;
  let fixture: ComponentFixture<ClientFindComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ClientFindComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ClientFindComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
