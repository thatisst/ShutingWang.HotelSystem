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
    public class ServiceService : IServiceService
    {
        private readonly IServiceRepository _serviceRepository;
        private readonly IMapper _mapper;

        public ServiceService(IServiceRepository serviceRepository
            , IMapper mapper)
        {
            _serviceRepository = serviceRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponseModel> AddNewServiceAsync(ServiceRequestModel serviceRequestModel)
        {
            var service = _mapper.Map<Service>(serviceRequestModel);
            var createdService = await _serviceRepository.AddServiceAsync(service);
            return _mapper.Map<ServiceResponseModel>(createdService);
        }

        public async Task DeleteServiceInfoAsync(int id)
        {
            var service = await _serviceRepository.GetServiceByIdAsync(id);
            await _serviceRepository.DeleteServiceAsync(service);
        }

        public async Task<ServiceResponseModel> GetServiceByIdAsync(int id)
        {
            var service = await _serviceRepository.GetServiceByIdAsync(id);
            return _mapper.Map<ServiceResponseModel>(service);
        }

        public async Task<IEnumerable<ServiceResponseModel>> ListAllServicesAsync()
        {
            var service = await _serviceRepository.ListAllServicesAsync();
            return _mapper.Map<IEnumerable<ServiceResponseModel>>(service);
        }

        public async Task<ServiceResponseModel> UpdateServiceDetailsAsync(ServiceRequestModel serviceRequestModel)
        {
            var service = _mapper.Map<Service>(serviceRequestModel);
            var updatedServices = await _serviceRepository.UpdateServiceAsync(service);
            return _mapper.Map<ServiceResponseModel>(updatedServices);
        }
    }
}
