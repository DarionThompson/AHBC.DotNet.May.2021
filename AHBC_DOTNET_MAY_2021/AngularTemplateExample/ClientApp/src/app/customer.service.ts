import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Customer } from './Models/Customer';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {
  //we may need to specify options for our post....
  apiUrl: string = "https://localhost:44377/api/Customers";
  constructor(private httpClient: HttpClient) { }
  
  getCustomers() {
    return this.httpClient.get<Customer[]>(this.apiUrl);
  }

  postCustomer(customer : Customer) : Observable<Customer> {
    return this.httpClient.post<Customer>(this.apiUrl, customer);
  }

  //update which is a put

  //delete which is a delete..
}
