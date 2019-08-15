using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityTrippr.Models
{
    public class Trip
    {
        [Key]
        public int TripId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Destination { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Description { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Highlight { get; set; }
        [Required]
        public int Days { get; set; }
        public string Related { get; set; }
        [Required]
        public int Food { get; set; }
        [Required]
        public int Weather { get; set; }
        [Required]
        public int Experience { get; set; }
    }
}
