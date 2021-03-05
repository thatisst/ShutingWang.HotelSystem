using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutingWang.HotelSystem.Core.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public int RtCode { get; set; }
        public bool Status { get; set; }

        public Roomtype Roomtype { get; set; }
        public ICollection<Service> Services { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
