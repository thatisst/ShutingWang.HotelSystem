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
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IRoomTypeRepository _roomTypeRepository;
        public RoomTypeService(IRoomTypeRepository roomTypeRepository)
        {
            _roomTypeRepository = roomTypeRepository;
        }

        public async Task<RoomTypeResponseModel> AddNewRoomTpyeAsync(RoomTypeRequestModel roomTypeRequestModel)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteRoomTypeInfoAsync(RoomTypeRequestModel roomTypeRequestModel)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RoomResponseModel>> ListAllRoomsByRoomTypeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RoomResponseModel>> ListAllRoomTypesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<RoomTypeResponseModel> UpdateRoomTypeDetailsAsync(RoomTypeRequestModel roomTypeRequestModel)
        {
            throw new NotImplementedException();
        }
    }
}
