using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutingWang.HotelSystem.Core.Models.Request
{
    public class ServiceRequestModel
    {
        
        public int Id { get; set; }

        public int RoomNo { get; set; }

        [MaxLength(50)]
        public string SDesc { get; set; }
        public decimal Amount { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ServiceDate { get; set; }
    }
}
