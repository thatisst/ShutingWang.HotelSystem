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
    public class RoomTypeController : ControllerBase
    {
        private readonly IRoomTypeService _roomTypeService;
        public RoomTypeController(IRoomTypeService roomTypeService)
        {
            _roomTypeService = roomTypeService;
        }

        [HttpGet]
        [Route("", Name = "GetRoomTypes")]
        public async Task<ActionResult> ListAllRoomTypesAsync()
        {
            var roomType = await _roomTypeService.ListAllRoomTypesAsync();
            return Ok(roomType);
        }

        [HttpGet]
        [Route("{id:int}", Name = "GetRoomType")]
        public async Task<ActionResult> GetRoomTypeByIdAsync(int id)
        {
            var roomType = await _roomTypeService.GetRoomTypeByIdAsync(id);
            return Ok(roomType);
        }

        [HttpPost]
        [Route("add")]
        public async Task<ActionResult> AddNewRoomTpyeAsync(RoomTypeRequestModel roomTypeRequestModel)
        {
            var roomType = await _roomTypeService.AddNewRoomTpyeAsync(roomTypeRequestModel);
            return Ok(roomType);
        }

        [HttpPost]
        [Route("update")]
        public async Task<ActionResult> UpdateRoomTypeDetailsAsync(RoomTypeRequestModel roomTypeRequestModel)
        {
            var roomType = await _roomTypeService.UpdateRoomTypeDetailsAsync(roomTypeRequestModel);
            return Ok(roomType);
        }

        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult> DeleteRoomTypeInfoAsync(int id)
        {
            await _roomTypeService.DeleteRoomTypeInfoAsync(id);
            return Ok();
        }
    }
}
