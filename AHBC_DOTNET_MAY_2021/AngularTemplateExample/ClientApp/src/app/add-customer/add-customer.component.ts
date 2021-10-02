import { conditionallyCreateMapObjectLiteral } from '@angular/compiler/src/render3/view/util';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CustomerService } from '../customer.service';
import { Customer } from '../Models/Customer';

@Component({
  selector: 'app-add-customer',
  templateUrl: './add-customer.component.html',
  styleUrls: ['./add-customer.component.css']
})
export class AddCustomerComponent implements OnInit {

  constructor(private customerService : CustomerService, private router : Router) { }

  ngOnInit() {
  }

  addCustomer(contactName: string,
              companyName: string,
              contactTitle: string,
              address: string,
              city: string)
  {
    //I would like something to happen
    //I am going to create a new object based on my params
    //Then call customer service post method

    //let customer = {
    //  //CustomerId = customerId; EFCore and the database handles this for us
    //  ContactName : 
    //}

    let customer = new Customer();
    customer.contactName = contactName;
    customer.companyName = companyName;
    customer.contactTitle = contactTitle;
    customer.address = address;
    customer.city = city;
    //On success nothing will happen on the UI side. we should reroute.
    this.customerService.postCustomer(customer)
      .subscribe(result => {
        //logging here
        this.router.navigateByUrl('/customers')
      }, (error: Response) =>
      {
        if (error.status === 404) {
          console.log('Not found');
          alert('Not found');
        }

        if (error.status === 500) {

        }
        console.log(error.json);
      });
  }
}
