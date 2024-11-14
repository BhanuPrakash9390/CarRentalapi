using System.ComponentModel.DataAnnotations;

namespace CarRentalapi.Models
{
    public class VehicleTypes
    {
        public int VehicleTypesId { get; set; }
        [MaxLength(40)]
        public string? Type { get; set; }
    }
}
