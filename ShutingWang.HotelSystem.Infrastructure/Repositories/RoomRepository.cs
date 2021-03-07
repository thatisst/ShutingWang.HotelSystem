using Microsoft.EntityFrameworkCore;
using ShutingWang.HotelSystem.Core.Entities;
using ShutingWang.HotelSystem.Core.Exceptions;
using ShutingWang.HotelSystem.Core.RepositoryInterfaces;
using ShutingWang.HotelSystem.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShutingWang.HotelSystem.Infrastructure.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        protected readonly HotelSystemDbContext _dbContext;
        public RoomRepository(HotelSystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Room> AddRoomAsync(Room room)
        {
            _dbContext.Set<Room>().Add(room);
            await _dbContext.SaveChangesAsync();
            return room;
        }

        public async Task DeleteRoomAsync(Room room)
        {
            _dbContext.Set<Room>().Remove(room);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Room> GetRoomByIdAsync(int id)
        {
            var room = await _dbContext.Rooms.Include(r => r.Customers).Include(r => r.Roomtype)
                .FirstOrDefaultAsync(r => r.Id == id);
            if (room == null)
                throw new NotFoundException("Room Not found");
            return room;
        }

        public async Task<IEnumerable<Room>> ListAllRoomsAsync()
        {
            return await _dbContext.Set<Room>().Include(r => r.Roomtype).ToListAsync();
        }

        public async Task<IEnumerable<Room>> ListAsync(Expression<Func<Room, bool>> filter)
        {
            var filteredList = await _dbContext.Set<Room>().Where(filter).ToListAsync();
            return filteredList;
        }

        public async Task<Room> UpdateRoomAsync(Room room)
        {
            _dbContext.Entry(room).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return room;
        }
    }
}
