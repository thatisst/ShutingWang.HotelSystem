using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShutingWang.HotelSystem.Core.Models.Request;
using ShutingWang.HotelSystem.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShutingWang.HotelSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService _customerService;
        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("{id:int}", Name = "GetCustomer")]
        public async Task<ActionResult> GetCustomerByIdAsync(int id)
        {
            var customer = await _customerService.GetCustomerByIdAsync(id);
            return Ok(customer);
        }

        [HttpPost]
        [Route("add")]
        public async Task<ActionResult> AddCustomerAsync(CustomerRequestModel customerRequestModel)
        {
            var customer = await _customerService.AddNewCustomerAsync(customerRequestModel);
            return Ok(customer);
        }

        [HttpPost]
        [Route("update")]
        public async Task<ActionResult> UpdateCustomerAsync(CustomerRequestModel customerRequestModel)
        {
            var customer = await _customerService.UpdateCustomerDetailsAsync(customerRequestModel);
            return Ok(customer);
        }

        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult> DeleteCustomerAsync(CustomerRequestModel customerRequestModel)
        {
            await _customerService.DeleteCustomerInfoAsync(customerRequestModel);
            return Ok();
        }

    }
}
