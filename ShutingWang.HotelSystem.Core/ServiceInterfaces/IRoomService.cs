using ShutingWang.HotelSystem.Core.Models.Request;
using ShutingWang.HotelSystem.Core.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutingWang.HotelSystem.Core.ServiceInterfaces
{
    public interface IRoomService
    {
        Task<bool> isRoomOccupiedAsync(int id);
        Task<RoomResponseModel> AddNewRoomTpyeAsync(RoomRequestModel roomTypeRequestModel);
        Task<RoomResponseModel> UpdateRoomTypeDetailsAsync(RoomRequestModel roomTypeRequestModel);
        Task DeleteRoomTypeInfoAsync(RoomRequestModel roomTypeRequestModel);
        Task<IEnumerable<RoomResponseModel>> ListAllRoomTypesAsync();

    }
}
