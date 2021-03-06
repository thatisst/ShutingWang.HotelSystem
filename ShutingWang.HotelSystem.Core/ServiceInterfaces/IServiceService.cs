using ShutingWang.HotelSystem.Core.Models.Request;
using ShutingWang.HotelSystem.Core.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutingWang.HotelSystem.Core.ServiceInterfaces
{
    public interface IServiceService
    {
        Task<ServiceResponseModel> AddNewService(ServiceRequestModel serviceRequestModel);
        Task<ServiceResponseModel> UpdateServiceDetails(ServiceRequestModel serviceRequestModel);
        Task DeleteServiceInfo(ServiceRequestModel serviceRequestModel);
        Task<ServiceResponseModel> ListAllServices(ServiceRequestModel serviceRequestModel);
    }
}
