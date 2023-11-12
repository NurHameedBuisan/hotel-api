using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAnytimePublicAPI.Models
{
    [Table("HotelReviews")]
    public class HotelReview
    {
        [Key]
        [Required]
        public int id { get; set; }
        public string author { get; set; }
        public string email { get; set; }
        public string comment { get; set; }
        public int hotel_id { get; set; }
        [ForeignKey("hotel_id")]
        public Hotel hotel { get; set; }
    }
}
