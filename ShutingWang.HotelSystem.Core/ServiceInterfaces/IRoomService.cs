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
    }
}
