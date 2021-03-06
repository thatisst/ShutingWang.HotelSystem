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
    public class ServiceService : IServiceService
    {
        private readonly IServiceRepository _serviceRepository;
        public ServiceService(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public async Task<ServiceResponseModel> AddNewService(ServiceRequestModel serviceRequestModel)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteServiceInfo(ServiceRequestModel serviceRequestModel)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponseModel> ListAllServices(ServiceRequestModel serviceRequestModel)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponseModel> UpdateServiceDetails(ServiceRequestModel serviceRequestModel)
        {
            throw new NotImplementedException();
        }
    }
}
