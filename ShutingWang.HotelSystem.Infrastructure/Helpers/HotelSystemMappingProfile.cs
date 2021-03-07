using AutoMapper;
using ShutingWang.HotelSystem.Core.Entities;
using ShutingWang.HotelSystem.Core.Models.Request;
using ShutingWang.HotelSystem.Core.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutingWang.HotelSystem.Infrastructure.Helpers
{
    public class HotelSystemMappingProfile : Profile
    {
        public HotelSystemMappingProfile()
        {
            CreateMap<Customer, CustomerResponseModel>()
                .ForMember(c => c.RoomRypeDesc, opt => opt.MapFrom(src => src.Room.Roomtype.RtDesc));
            CreateMap<Service, ServiceResponseModel>();
            CreateMap<Room, RoomResponseModel>()
                .ForMember(r => r.Rent, opt => opt.MapFrom(src => src.Roomtype.Rent))
                .ForMember(r => r.RtDesc, opt => opt.MapFrom(src => src.Roomtype.RtDesc));                
            CreateMap<Roomtype, RoomTypeResponseModel>();

            CreateMap<CustomerRequestModel, Customer>();
            CreateMap<RoomRequestModel, Room>();
            CreateMap<RoomTypeRequestModel, Roomtype>();
            CreateMap<ServiceRequestModel, Service>();
        }

        //private RoomResponseModel.RoomtypeModel GetRoomType(Room room)
        //{
        //    var roomType = room.Roomtype;


        //}
    }
}
