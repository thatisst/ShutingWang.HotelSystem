using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShutingWang.HotelSystem.Core.Models.Request;
using ShutingWang.HotelSystem.Core.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShutingWang.HotelSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;
        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        [Route("", Name = "GetServices")]
        public async Task<ActionResult> ListAllServicesAsync()
        {
            var service = await _serviceService.ListAllServicesAsync();
            return Ok(service);
        }

        [HttpGet]
        [Route("{id:int}", Name = "GetService")]
        public async Task<ActionResult> GetServiceByIdAsync(int id)
        {
            var service = await _serviceService.GetServiceByIdAsync(id);
            return Ok(service);
        }

        [HttpPost]
        [Route("add")]
        public async Task<ActionResult> AddNewServiceAsync(ServiceRequestModel serviceRequestModel)
        {
            var service = await _serviceService.AddNewServiceAsync(serviceRequestModel);
            return Ok(service);
        }

        [HttpPost]
        [Route("update")]
        public async Task<ActionResult> UpdateServiceDetailsAsync(ServiceRequestModel serviceRequestModel)
        {
            var service = await _serviceService.UpdateServiceDetailsAsync(serviceRequestModel);
            return Ok(service);
        }

        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult> DeleteServiceInfoAsync(int id)
        {
            await _serviceService.DeleteServiceInfoAsync(id);
            return Ok();
        }
    }
}
