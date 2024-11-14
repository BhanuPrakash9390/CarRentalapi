using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalapi.Models
{
    public class Drivers
    {
        public int DriversId { get; set; } 
        public string? Name { get; set; } 
        public string? LicenceNumber { get; set; }
        public string? AddressLine1 { get; set; } 
        public string? AddressLine2 { get; set; } 
        public int? CitiesId { get; set; } 
        public int? StatesId { get; set; }
        public string? Pincode { get; set; } 
        public int? CountriesId { get; set; }
        public string? PhoneNumber { get; set; } 
        public string? MobileNumber { get; set; }
        public string? BankName { get; set; } 
        public string? BankAccount { get; set; } 
        public string? PAN { get; set; } 
        public string? DeleteStatus { get; set; } 

        public virtual Cities? City { get; set; }
        public virtual States? State { get; set; }
        public virtual Countries? Country { get; set; }
    }
}
