using ShutingWang.HotelSystem.Core.Models.Request;
using ShutingWang.HotelSystem.Core.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutingWang.HotelSystem.Core.ServiceInterfaces
{
    public interface IRoomTypeService
    {
        Task<RoomTypeResponseModel> AddNewRoomTpyeAsync(RoomTypeRequestModel roomTypeRequestModel);
        Task<RoomTypeResponseModel> UpdateRoomTypeDetailsAsync(RoomTypeRequestModel roomTypeRequestModel);
        Task DeleteRoomTypeInfoAsync(RoomTypeRequestModel roomTypeRequestModel);
        Task<IEnumerable<RoomResponseModel>> ListAllRoomTypesAsync();
        Task<IEnumerable<RoomResponseModel>> ListAllRoomsByRoomTypeAsync(int id);

    }
}
