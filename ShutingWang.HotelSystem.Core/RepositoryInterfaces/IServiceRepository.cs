using ShutingWang.HotelSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutingWang.HotelSystem.Core.RepositoryInterfaces
{
    public interface IServiceRepository
    {
        //Task<Service> GetServiceByIdAsync(int id);
        Task<IEnumerable<Service>> ListAllServicesAsync();
        Task<Service> AddServiceAsync(Service service);
        Task<Service> UpdateServiceAsync(Service service);
        Task DeleteServiceAsync(Service service);
    }
}
