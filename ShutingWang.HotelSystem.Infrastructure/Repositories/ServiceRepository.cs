using Microsoft.EntityFrameworkCore;
using ShutingWang.HotelSystem.Core.Entities;
using ShutingWang.HotelSystem.Core.Exceptions;
using ShutingWang.HotelSystem.Core.RepositoryInterfaces;
using ShutingWang.HotelSystem.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutingWang.HotelSystem.Infrastructure.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        protected readonly HotelSystemDbContext _dbContext;
        public ServiceRepository(HotelSystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Service> AddServiceAsync(Service service)
        {
            
            _dbContext.Set<Service>().Add(service);
            await _dbContext.SaveChangesAsync();
            return service;
           
        }

        public async Task DeleteServiceAsync(Service service)
        {
            _dbContext.Set<Service>().Remove(service);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Service> GetServiceByIdAsync(int id)
        {
            var service = await _dbContext.Services.FirstOrDefaultAsync();
            if (service == null)
                throw new NotFoundException("Room Type Not found");
            return service;
        }

        public async Task<IEnumerable<Service>> ListAllServicesAsync()
        {
            return await _dbContext.Set<Service>().ToListAsync();
        }

        public async Task<Service> UpdateServiceAsync(Service service)
        {
            _dbContext.Entry(service).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return service;
        }
    }
}
