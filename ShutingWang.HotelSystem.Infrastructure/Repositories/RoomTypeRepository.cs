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
    public class RoomTypeRepository : IRoomTypeRepository
    {
        protected readonly HotelSystemDbContext _dbContext;
        public RoomTypeRepository(HotelSystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Roomtype> AddRoomTypeAsync(Roomtype roomType)
        {
            _dbContext.Set<Roomtype>().Add(roomType);
            await _dbContext.SaveChangesAsync();
            return roomType;
        }

        public async Task DeleteRoomTypeAsync(Roomtype roomType)
        {
            _dbContext.Set<Roomtype>().Remove(roomType);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Roomtype>> ListAllRoomTypesAsync()
        {
            return await _dbContext.Set<Roomtype>().ToListAsync();
        }

        public async Task<Roomtype> UpdateRoomTypeAsync(Roomtype roomType)
        {
            _dbContext.Entry(roomType).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return roomType;
        }
    }
}
