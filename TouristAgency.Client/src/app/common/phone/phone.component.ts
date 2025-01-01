import { Directive, Component, Inject, OnInit, Input, Output, EventEmitter, ElementRef, HostListener, forwardRef } from '@angular/core';
import {CountryISO, PhoneNumberFormat, SearchCountryField} from "ngx-intl-tel-input";





@Component({
  selector: 'phone',
  standalone: true,
  templateUrl: 'phone.component.html',
  styles: ['input.ng-dirty.ng-invalid { border: 2px solid #ff0000 !important }',
    'input.ng-dirty.ng-valid { border: 2px solid #6bc502 !important  }'
  ]
})
export class PhoneComponent {

  noError: boolean = true;
  number:string ="" ;
  id: string = "";

  separateDialCode = false;
  searchCountryField = SearchCountryField;
  countryISO = CountryISO;
  phoneNumberFormat = PhoneNumberFormat;
  preferredCountries: CountryISO[] = [CountryISO.Russia, CountryISO.Ukraine];

}
