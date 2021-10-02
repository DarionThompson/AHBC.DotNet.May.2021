import { Component, OnInit } from '@angular/core';
import { CustomerService } from '../customer.service';
import { Customer } from '../Models/Customer';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit {
  customers: Customer[];
  constructor(private customerService : CustomerService) { }

  ngOnInit() {
    this.customerService.getCustomers()
      .subscribe(result => {
        this.customers = result;
      })
  }

}
