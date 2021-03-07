using Microsoft.AspNetCore.Mvc;
using ShutingWang.HotelSystem.Core.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShutingWang.HotelSystem.MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public  IActionResult ListAllCustomers()
        {
            //var customer = await _customerService.ListAllCustomersAsync();
            //return View(customer);
            return View();
        }
    }
}
