using System.ComponentModel.DataAnnotations;

namespace CarRentalapi.Models
{
    public class EmployeeTypes
    {
        public int EmployeeTypesId { get; set; }

        [MaxLength(40)]
        public string? Type { get; set; }
    }
}
