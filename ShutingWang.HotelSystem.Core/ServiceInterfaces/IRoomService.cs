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
        Task<RoomResponseModel> AddNewRoomAsync(RoomRequestModel roomRequestModel);
        Task<RoomResponseModel> UpdateRoomDetailsAsync(RoomRequestModel roomRequestModel);
        Task DeleteRoomInfoAsync(int id);
        Task<IEnumerable<RoomResponseModel>> ListAllRoomAsync();

        Task<IEnumerable<RoomResponseModel>> ListAllRoomsByRoomTypeAsync(int id);
        Task<RoomResponseModel> GetRoomByIdAsync(int id);



    }
}
