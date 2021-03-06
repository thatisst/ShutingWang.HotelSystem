using ShutingWang.HotelSystem.Core.Models.Request;
using ShutingWang.HotelSystem.Core.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutingWang.HotelSystem.Core.ServiceInterfaces
{
    public interface ICustomerService
    {
        Task<CustomerResponseModel> AddNewCustomer(CustomerRequestModel customerRequestModel);
        Task<CustomerResponseModel> UpdateCustomerDetails(CustomerRequestModel customerRequestModel);
        Task DeleteCustomerInfo(CustomerRequestModel customerRequestModel);
        Task<CustomerResponseModel> ListAllCustomers(CustomerRequestModel customerRequestModel);
    }
}
