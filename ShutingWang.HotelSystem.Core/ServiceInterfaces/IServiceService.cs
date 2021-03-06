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
        Task<ServiceResponseModel> AddNewServiceAsync(ServiceRequestModel serviceRequestModel);
        Task<ServiceResponseModel> UpdateServiceDetailsAsync(ServiceRequestModel serviceRequestModel);
        Task DeleteServiceInfoAsync(ServiceRequestModel serviceRequestModel);
        Task<IEnumerable<ServiceResponseModel>> ListAllServicesAsync();
    }
}
