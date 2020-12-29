using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartialViewUsage.Models;

namespace PartialViewUsage.Controllers
{
    public class CustomerController : Controller
    {
        //[HttpGet]
        public List<Customer> customerList = new List<Customer>();
        public IActionResult Index()
        {

            var cust1 = new Customer();
            cust1.Name = "Name1";
            cust1.Surname = "Surname1";
            cust1.Age = 23;
            cust1.Phone = "234544";
            cust1.Address = "istanbul";
            cust1.CustomerStatus = true;
            customerList.Add(cust1);

            var cust2 = new Customer();
            cust2.Name = "Name2";
            cust2.Surname = "Surname2";
            cust2.Age = 44;
            cust2.Phone = "5557776654";
            cust2.Address = "istanbul/Beyoğlu";
            cust2.CustomerStatus = false;
            customerList.Add(cust2);
            return View(customerList);
        }
        //public ActionResult getCustomer()
        //{

        //}
        public ActionResult addCustomer(Customer customer)
        {
            Customer cust3 = new Customer();
            cust3.Name = customer.Name;
            cust3.Surname= customer.Surname;
            cust3.Age = customer.Age;
            cust3.Address = customer.Address;
            cust3.Phone = customer.Phone;
            cust3.CustomerStatus = true;
            customerList.Add(cust3);
            return View(customer);
        }
    }
}
