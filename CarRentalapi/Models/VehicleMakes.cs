using System.ComponentModel.DataAnnotations;

namespace CarRentalapi.Models
{
    public class VehicleMakes
    {
        public int VehicleMakesId { get; set; }

        [MaxLength(40)]
        public string? Name { get; set; }
    }
}
