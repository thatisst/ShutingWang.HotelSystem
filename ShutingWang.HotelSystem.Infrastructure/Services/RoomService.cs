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
        public async Task<bool> isRoomOccupied(int id)
        {
            var room = await _roomRepository.GetRoomByIdAsync(id);
            var isOccupied = !room.Status; // true as empty; false as occupied
            return isOccupied;
        }
    }
}
