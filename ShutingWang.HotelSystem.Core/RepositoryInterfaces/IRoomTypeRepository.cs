using Aspose.Email.Clients.Exchange.WebService.Schema_2016;
using ShutingWang.HotelSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutingWang.HotelSystem.Core.RepositoryInterfaces
{
    public interface IRoomTypeRepository
    {
        Task<Roomtype> GetRoomTypeByIdAsync(int id);
        Task<IEnumerable<Roomtype>> ListAllRoomTypesAsync();
        Task<Roomtype> AddRoomTypeAsync(Roomtype roomType);
        Task<Roomtype> UpdateRoomTypeAsync(Roomtype roomType);
        Task DeleteRoomTypeAsync(Roomtype roomType);
    }
}
