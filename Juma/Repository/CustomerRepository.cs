using System.Collections.Generic;
using CsharpAutofacDemo.Models;
using Autofac;

namespace CsharpAutofacDemo
{
    /// <summary>
    /// Customer details repository class
    /// </summary>
    public class CustomerRepository : ICustomerRepository
    {
        /// <summary>
        /// Get customer details.
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetCustomerDetails()
        {
            // This is a simple implementation, others could use an ORM or Web service etc.

            var customers = new List<Customer>
                          {
                              new Customer()
                                  {
                                      CustomerId = "1",
                                      CustomerName = "Customer one",
                                      CustomerAddress = "Bristol",
                                      CustomerPhoneNumber = "0845000000",
                                      CustomerEmail = "x@y.com",
                                  },
                              new Customer()
                                  {
                                      CustomerId = "2",
                                      CustomerName = "Customer two",
                                      CustomerAddress = "Bath",
                                      CustomerPhoneNumber = "0845000001",
                                      CustomerEmail = "x@x.com",
                                  },
                              new Customer()
                                  {
                                      CustomerId = "3",
                                      CustomerName = "Customer three",
                                      CustomerAddress = "Swindon",
                                      CustomerPhoneNumber = "0845000003",
                                      CustomerEmail = "y@y.com",
                                  }
                          };

            return customers;
        }
    }
}