﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutingWang.HotelSystem.Core.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public int RoomNo { get; set; }
        public string CName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Checkin { get; set; }
        public int TotalPersons { get; set; }
        public int BookingDays { get; set; }
        public decimal Advance { get; set; }

        public Room Room { get; set; }
    }
}
