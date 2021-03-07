using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutingWang.HotelSystem.Core.Models.Response
{
    public class RoomWithCustomerResponseModel
    {
        public int Id { get; set; }
        public bool Status { get; set; }

        public IEnumerable<CustomerModel> Customers { get; set; }

        public class CustomerModel
        {
            public int Id { get; set; }           
            public DateTime Checkin { get; set; }
            public int TotalPersons { get; set; }
            public int BookingDays { get; set; }
        }
    }
}
