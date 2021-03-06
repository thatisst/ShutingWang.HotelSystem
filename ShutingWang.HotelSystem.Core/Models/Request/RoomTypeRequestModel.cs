using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutingWang.HotelSystem.Core.Models.Request
{
    public class RoomTypeRequestModel
    {
        
        public int Id { get; set; }
        [MaxLength(20)]
        public string RtDesc { get; set; }
        [Required]
        public decimal Rent { get; set; }

    }
}
