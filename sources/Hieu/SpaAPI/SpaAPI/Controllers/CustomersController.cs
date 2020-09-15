using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpaAPI.Models;

namespace SpaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        SpaManagementContext context = new SpaManagementContext();

        [HttpGet]
        public Customer GetCustomer(int id)
        {
            Customer customer = new Customer();
            using (context)
            {
                customer = context.Customer
                    .Where(_customer => _customer.CustomerId == id)
                    .Select(_customer => new Customer()
                    {
                        CustomerId = _customer.CustomerId,
                        CustomerName = _customer.CustomerName,
                        Address = _customer.Address,
                        Phone = _customer.Phone,
                        Email = _customer.Email,
                        Dob = _customer.Dob,

                    }).FirstOrDefault();
            }

            return customer;
        }
    }
    
}
