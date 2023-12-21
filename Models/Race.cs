using RunGroopWebApp.Data.Enum;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RunGroopWebApp.Models
{
    public class Race
    {

        [Key]
        public int Id { get; set; }

        public String Title { get; set; }

        public string Description { get; set; }

        public string? Image { get; set; }
        
        [ForeignKey("Address")]
        public int AddressId { get; set; }

        public Address Address { get; set; }

        public RaceCategory RaceCategory { get; set; }

        [ForeignKey("AppUser")]
        public String? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }

    }
}
