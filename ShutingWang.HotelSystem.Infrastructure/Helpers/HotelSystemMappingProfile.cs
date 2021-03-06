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
            CreateMap<Customer, CustomerResponseModel>();
            CreateMap<Service, ServiceResponseModel>();
            CreateMap<Room, RoomResponseModel>();
            CreateMap<Roomtype, RoomTypeResponseModel>();
            CreateMap<CustomerRequestModel, Customer>();
            CreateMap<RoomRequestModel, Room>();
            CreateMap<RoomTypeRequestModel, Roomtype>();
            CreateMap<ServiceRequestModel, Service>();
        }
    }
}
