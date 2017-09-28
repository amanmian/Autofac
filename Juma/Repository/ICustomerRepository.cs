using System.Collections.Generic;
using CsharpAutofacDemo.Models;

namespace CsharpAutofacDemo
{
    /// <summary>
    /// ICustomerRepository interface
    /// </summary>
    public interface ICustomerRepository
    {
        List<Customer> GetCustomerDetails();
    }
}