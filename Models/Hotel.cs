using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAnytimePublicAPI.Models
{
    [Table("Hotels")]
    public class Hotel
    {
        [Key]
        [Required]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string phone_number { get; set; }
        public string hotel_email { get; set; }
        public string address { get; set; }
        public string image_url { get; set; }
        public List<HotelReview> reviews { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
