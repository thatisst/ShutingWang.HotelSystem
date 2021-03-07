using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShutingWang.HotelSystem.Core.Models.Request;
using ShutingWang.HotelSystem.Core.ServiceInterfaces;
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
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("", Name = "GetCustomers")]
        public async Task<ActionResult> ListAllCustomerAsync()
        {
            var customer = await _customerService.ListAllCustomersAsync();
            return Ok(customer);
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

        [HttpPut]
        [Route("update/{id:int}")]
        public async Task<ActionResult> UpdateCustomerAsync(CustomerRequestModel customerRequestModel)
        {
            int id = customerRequestModel.Id;
            var customer = await _customerService.UpdateCustomerDetailsAsync(customerRequestModel);
            return Ok(customer);
        }

        [HttpDelete]
        [Route("delete/{id:int}")]
        public async Task<ActionResult> DeleteCustomerAsync(int id)
        {
            await _customerService.DeleteCustomerInfoAsync(id);
            return Ok();
        }

    }
}
