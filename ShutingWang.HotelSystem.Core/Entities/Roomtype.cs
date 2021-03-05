﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutingWang.HotelSystem.Core.Entities
{
    public class Roomtype
    {
        public int Id { get; set; }
        public string RtDesc { get; set; }
        public decimal Rent { get; set; }

        public ICollection<Room> Rooms { get; set; }


    }
}
