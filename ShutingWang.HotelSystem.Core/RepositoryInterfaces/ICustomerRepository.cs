using ShutingWang.HotelSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutingWang.HotelSystem.Core.RepositoryInterfaces
{
    public interface ICustomerRepository
    {
        Task<Customer> GetCustomerByIdAsync(int id);
        Task<IEnumerable<Customer>> ListAllCustomersAsync();
        Task<Customer> AddCustomerAsync(Customer customer);
        Task<Customer> UpdateCustomerAsync(Customer customer);
        Task DeleteCustomerAsync(Customer customer);

    }
}
