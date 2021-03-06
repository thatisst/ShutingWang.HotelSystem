using ShutingWang.HotelSystem.Core.Models.Request;
using ShutingWang.HotelSystem.Core.Models.Response;
using ShutingWang.HotelSystem.Core.RepositoryInterfaces;
using ShutingWang.HotelSystem.Core.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutingWang.HotelSystem.Infrastructure.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public async Task<RoomResponseModel> AddNewRoomTpye(RoomRequestModel roomTypeRequestModel)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteRoomTypeInfo(RoomRequestModel roomTypeRequestModel)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> isRoomOccupied(int id)
        {
            var room = await _roomRepository.GetRoomByIdAsync(id);
            var isOccupied = !room.Status; // true as empty; false as occupied
            return isOccupied;
        }

        public async Task<RoomResponseModel> ListAllRoomTypes(RoomRequestModel roomTypeRequestModel)
        {
            throw new NotImplementedException();
        }

        public async Task<RoomResponseModel> UpdateRoomTypeDetails(RoomRequestModel roomTypeRequestModel)
        {
            throw new NotImplementedException();
        }
    }
}
