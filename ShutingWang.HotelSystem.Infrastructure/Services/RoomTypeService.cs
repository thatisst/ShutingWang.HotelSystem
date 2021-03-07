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
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IRoomTypeRepository _roomTypeRepository;
        private readonly IMapper _mapper;

        public RoomTypeService(IRoomTypeRepository roomTypeRepository
            , IMapper mapper)
        {
            _roomTypeRepository = roomTypeRepository;
            _mapper = mapper;
        }

        public async Task<RoomTypeResponseModel> AddNewRoomTpyeAsync(RoomTypeRequestModel roomTypeRequestModel)
        {
            var roomType = _mapper.Map<Roomtype>(roomTypeRequestModel);
            var createdRoomType = await _roomTypeRepository.AddRoomTypeAsync(roomType);
            return _mapper.Map<RoomTypeResponseModel>(createdRoomType);
        }

        public async Task DeleteRoomTypeInfoAsync(int id)
        {
            var roomType = await _roomTypeRepository.GetRoomTypeByIdAsync(id);
            await _roomTypeRepository.DeleteRoomTypeAsync(roomType);
        }

        public async Task<RoomTypeResponseModel> GetRoomTypeByIdAsync(int id)
        {
            var roomType = await _roomTypeRepository.GetRoomTypeByIdAsync(id);
            return _mapper.Map<RoomTypeResponseModel>(roomType);
        }

        public async Task<IEnumerable<RoomTypeResponseModel>> ListAllRoomTypesAsync()
        {
            var roomType = await _roomTypeRepository.ListAllRoomTypesAsync();
            return _mapper.Map<IEnumerable<RoomTypeResponseModel>>(roomType);
        }

        public async Task<RoomTypeResponseModel> UpdateRoomTypeDetailsAsync(RoomTypeRequestModel roomTypeRequestModel)
        {
            var roomType = _mapper.Map<Roomtype>(roomTypeRequestModel);
            var updatedRoomType = await _roomTypeRepository.UpdateRoomTypeAsync(roomType);
            return _mapper.Map<RoomTypeResponseModel>(updatedRoomType);
        }
    }
}
