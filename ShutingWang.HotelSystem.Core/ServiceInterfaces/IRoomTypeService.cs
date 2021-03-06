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
        Task<RoomTypeResponseModel> AddNewRoomTpye(RoomTypeRequestModel roomTypeRequestModel);
        Task<RoomTypeResponseModel> UpdateRoomTypeDetails(RoomTypeRequestModel roomTypeRequestModel);
        Task DeleteRoomTypeInfo(RoomTypeRequestModel roomTypeRequestModel);
        Task<RoomTypeResponseModel> ListAllRoomTypes(RoomTypeRequestModel roomTypeRequestModel);
        Task<IEnumerable<RoomResponseModel>> ListAllRoomsByRoomType(int id);

    }
}
