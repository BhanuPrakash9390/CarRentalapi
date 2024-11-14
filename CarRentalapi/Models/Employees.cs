using CarRentalapi.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineCarRentals.Models
{
    public class Employee
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; } 

        [MaxLength(40)]
        public string? Name { get; set; } 

        public int? EmployeeTypesId { get; set; } 

        [MaxLength(100)]
        public string? Address1 { get; set; } 

        [MaxLength(100)]
        public string? Address2 { get; set; } 

        public int? CitiesId { get; set; } 
        public int? StatesId { get; set; }

        [MaxLength(15)]
        public string? Pincode { get; set; } 

        public int? CountriesId { get; set; } 

        [MaxLength(15)]
        public string? PhoneNumber { get; set; } 

        [MaxLength(15)]
        public string? MobileNumber { get; set; } 

        [MaxLength(75)]
        public string? EmailAddress { get; set; } 

        [MaxLength(40)]
        public string? BankName { get; set; } 

        [MaxLength(15)]
        public string? BankAccount { get; set; } 

        [MaxLength(20)]
        public string? PAN { get; set; } 

        [MaxLength(20)]
        public string? Username { get; set; } 

        [MaxLength(10)]
        public string? Password { get; set; } 

        [MaxLength(10)]
        public string? Vehicles { get; set; } 

        [MaxLength(10)]
        public string? VehicleMakes { get; set; } 

        [MaxLength(10)]
        public string? VehicleModels { get; set; }

        [MaxLength(10)]
        public string? Employees { get; set; } 

        [MaxLength(10)]
        public string? Customers { get; set; } 

        [MaxLength(10)]
        public string? Owners { get; set; } 

        [MaxLength(10)]
        public string? Drivers { get; set; } 

        [MaxLength(10)]
        public string? Rentals { get; set; } 

        public DateTime? LastLogin { get; set; } 

        [MaxLength(10)]
        public string? Status { get; set; } 

        [MaxLength(2)]
        public string? DeleteStatus { get; set; } 

        public virtual Cities? City { get; set; }
        public virtual States? State { get; set; }
        public virtual Countries? Country { get; set; }
        public virtual EmployeeTypes? EmployeeType { get; set; }
    }
}
