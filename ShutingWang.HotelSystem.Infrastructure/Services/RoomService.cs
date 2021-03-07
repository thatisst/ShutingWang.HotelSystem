using AutoMapper;
using ShutingWang.HotelSystem.Core.Entities;
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
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IMapper _mapper;

        public RoomService(IRoomRepository roomRepository
            , IMapper mapper)
        {
            _roomRepository = roomRepository;
            _mapper = mapper;
        }

        public async Task<RoomResponseModel> AddNewRoomAsync(RoomRequestModel roomRequestModel)
        {
            var room = _mapper.Map<Room>(roomRequestModel);
            var createdRoom = await _roomRepository.AddRoomAsync(room);
            return _mapper.Map<RoomResponseModel>(createdRoom);
        }

        public async Task DeleteRoomInfoAsync(int id)
        {
            var room = await _roomRepository.GetRoomByIdAsync(id);
            await _roomRepository.DeleteRoomAsync(room);
        }

        public async Task<RoomResponseModel> GetRoomByIdAsync(int id)
        {
            var room = await _roomRepository.GetRoomByIdAsync(id);
            return _mapper.Map<RoomResponseModel>(room);
        }

        public async Task<bool> isRoomOccupiedAsync(int id)
        {
            var room = await _roomRepository.GetRoomByIdAsync(id);
            var isOccupied = !room.Status; // true as empty; false as occupied
            return isOccupied;
        }

        public async Task<IEnumerable<RoomResponseModel>> ListAllRoomAsync()
        {
            var rooms = await _roomRepository.ListAllRoomsAsync();
            return _mapper.Map<IEnumerable<RoomResponseModel>>(rooms);
        }

        public async Task<IEnumerable<RoomResponseModel>> ListAllRoomsByRoomTypeAsync(int id)
        {
            var rooms = await _roomRepository.ListAsync(r => r.Roomtype.Id == id);
            return _mapper.Map<IEnumerable<RoomResponseModel>>(rooms);
        }

        public async Task<RoomResponseModel> UpdateRoomDetailsAsync(RoomRequestModel roomRequestModel)
        {
            var room = _mapper.Map<Room>(roomRequestModel);
            var updatedRoom = await _roomRepository.UpdateRoomAsync(room);
            return _mapper.Map<RoomResponseModel>(updatedRoom);
        }
    }
}
