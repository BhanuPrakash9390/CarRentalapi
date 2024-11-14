using CarRentalapi.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineCarRentals.Models
{
    public class Rentals
    {
        public int RentalsId { get; set; } 

        public int CustomersId { get; set; } 
        public int VehiclesId { get; set; } 

        public int? DriversId { get; set; } 
        public int? EmployeeId { get; set; } 

        public DateTime ReservationDate { get; set; } 
        public int VehicleRate { get; set; } 

        public int? NoOfDays { get; set; } 
        public DateTime StartDate { get; set; } 
        public DateTime EndDate { get; set; } 

        public int? NoOfKMS { get; set; } 

        public int? StartKMS { get; set; }
        public int? EndKMS { get; set; } 
        [ForeignKey("SourceCities")]
        public int SourceLocation { get; set; }
        [ForeignKey("DestinationCities")]
        public int DestinationLocation { get; set; } 

        [MaxLength(255)]
        public string? TravelPurpose { get; set; } 

        public int Amount { get; set; } 

        [MaxLength(50)]
        public string? TransactionNumber { get; set; } 

        [MaxLength(10)]
        public string? Status { get; set; } 

        public virtual Customers? Customers { get; set; }
        public virtual Vehicles? Vehicles { get; set; }
        public virtual Drivers? Drivers { get; set; }
        public virtual Employee? Employees { get; set; }
        public virtual States? States { get; set; }
        public virtual Cities? SourceCities { get; set; }
        public virtual Cities? DestinationCities { get; set; }
    }
}
