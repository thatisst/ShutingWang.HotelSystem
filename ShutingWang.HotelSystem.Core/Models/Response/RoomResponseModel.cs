using ShutingWang.HotelSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutingWang.HotelSystem.Core.Models.Response
{
    public class RoomResponseModel
    {
        public int Id { get; set; }
        public int RtCode { get; set; }
        public bool Status { get; set; }


        public string RtDesc { get; set; }
        public decimal Rent { get; set; }


        //public ICollection<Service> Services { get; set; }
        //public ICollection<Customer> Customers { get; set; }
    }
}
