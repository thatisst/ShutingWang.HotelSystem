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
        Task<bool> isRoomOccupied(int id);
        Task<RoomResponseModel> AddNewRoomTpye(RoomRequestModel roomTypeRequestModel);
        Task<RoomResponseModel> UpdateRoomTypeDetails(RoomRequestModel roomTypeRequestModel);
        Task DeleteRoomTypeInfo(RoomRequestModel roomTypeRequestModel);
        Task<RoomResponseModel> ListAllRoomTypes(RoomRequestModel roomTypeRequestModel);

    }
}
