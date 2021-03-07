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
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository
            , IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<CustomerResponseModel> AddNewCustomerAsync(CustomerRequestModel customerRequestModel)
        {
            var customer = _mapper.Map<Customer>(customerRequestModel);
            var createdCustomer = await _customerRepository.AddCustomerAsync(customer);
            return _mapper.Map<CustomerResponseModel>(createdCustomer);
        }

        public async Task DeleteCustomerInfoAsync(int id)
        {
            var customer = await _customerRepository.GetCustomerByIdAsync(id);
            await _customerRepository.DeleteCustomerAsync(customer);
        }

        public async Task<CustomerResponseModel> GetCustomerByIdAsync(int id)
        {
            var customer = await _customerRepository.GetCustomerByIdAsync(id);
            return _mapper.Map<CustomerResponseModel>(customer);
        }

        public async Task<IEnumerable<CustomerResponseModel>> ListAllCustomersAsync()
        {
            var customer = await _customerRepository.ListAllCustomersAsync();
            return _mapper.Map<IEnumerable<CustomerResponseModel>>(customer);
        }

        public async Task<CustomerResponseModel> UpdateCustomerDetailsAsync(CustomerRequestModel customerRequestModel)
        {
            var customer = _mapper.Map<Customer>(customerRequestModel);
            var updatedCustomer = await _customerRepository.UpdateCustomerAsync(customer);
            return _mapper.Map<CustomerResponseModel>(updatedCustomer);
        }

    }
}
