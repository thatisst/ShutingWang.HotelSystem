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
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }


        [HttpGet]
        [Route("", Name = "GetRooms")]
        public async Task<ActionResult> ListAllRoomAsync()
        {
            var room = await _roomService.ListAllRoomAsync();
            return Ok(room);
        }

        [HttpGet]
        [Route("{id:int}", Name = "GetRoom")]
        public async Task<ActionResult> GetRoomByIdAsync(int id)
        {
            var room = await _roomService.GetRoomByIdAsync(id);
            return Ok(room);
        }

        [HttpPost]
        [Route("add")]
        public async Task<ActionResult> AddNewRoomAsync(RoomRequestModel roomRequestModel)
        {
            var room = await _roomService.AddNewRoomAsync(roomRequestModel);
            return Ok(room);
        }

        [HttpPut]
        [Route("update/{id:int}")]
        public async Task<ActionResult> UpdateRoomDetailsAsync(RoomRequestModel roomRequestModel)
        {
            int id = roomRequestModel.Id;
            var room = await _roomService.UpdateRoomDetailsAsync(roomRequestModel);
            return Ok(room);
        }

        [HttpDelete]
        [Route("delete/{id:int}")]
        public async Task<ActionResult> DeleteRoomInfoAsync(int id)
        {
            await _roomService.DeleteRoomInfoAsync(id);
            return Ok();
        }
    }
}
