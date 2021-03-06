using Microsoft.EntityFrameworkCore;
using ShutingWang.HotelSystem.Core.Entities;
using ShutingWang.HotelSystem.Core.RepositoryInterfaces;
using ShutingWang.HotelSystem.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutingWang.HotelSystem.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        protected readonly HotelSystemDbContext _dbContext;
        public CustomerRepository(HotelSystemDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<Customer> AddCustomerAsync(Customer customer)
        {
            _dbContext.Set<Customer>().Add(customer);
            await _dbContext.SaveChangesAsync();
            return customer;
        }

        public async Task DeleteCustomerAsync(Customer customer)
        {
            _dbContext.Set<Customer>().Remove(customer);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>> ListAllCustomersAsync()
        {
            return await _dbContext.Set<Customer>().ToListAsync();
        }

        public async Task<Customer> UpdateCustomerAsync(Customer customer)
        {
            _dbContext.Entry(customer).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return customer;
        }
    }
}
