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
        Task<CustomerResponseModel> AddNewCustomerAsync(CustomerRequestModel customerRequestModel);
        Task<CustomerResponseModel> UpdateCustomerDetailsAsync(CustomerRequestModel customerRequestModel);
        Task DeleteCustomerInfoAsync(CustomerRequestModel customerRequestModel);
        Task<IEnumerable<CustomerResponseModel>> ListAllCustomersAsync();
        Task<CustomerResponseModel> GetCustomerByIdAsync(int id);
    }
}
