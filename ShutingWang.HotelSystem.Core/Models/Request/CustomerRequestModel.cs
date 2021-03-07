using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutingWang.HotelSystem.Core.Models.Request
{
    public class CustomerRequestModel
    {
       
        public int Id { get; set; }
        [Required]  
        public int RoomNo { get; set; }
        [Required]
        [MaxLength(20)]
        public string CName { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        [EmailAddress]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        public string Email { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Checkin { get; set; }
        [Required]
        public int TotalPersons { get; set; }
        [Required]
        public int BookingDays { get; set; }
        public decimal Advance { get; set; }
    }
}
