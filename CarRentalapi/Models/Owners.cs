using CarRentalapi.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineCarRentals.Models
{
    public class Owners
    {
        public int OwnersId { get; set; }

        [MaxLength(40)]
        public string? Name { get; set; }

        [MaxLength(100)]
        public string? Address1 { get; set; } 

        [MaxLength(100)]
        public string? Address2 { get; set; } 
        public int? CitiesId { get; set; } 
        public int? StatesId { get; set; }

        [MaxLength(15)]
        public string? PinCode { get; set; } 

        public int? CountriesId { get; set; } 

        [MaxLength(15)]
        public string? PhoneNumber { get; set; } 

        [MaxLength(15)]
        public string? MobileNumber { get; set; }

        [MaxLength(40)]
        public string? BankName { get; set; } 

        [MaxLength(15)]
        public string? BankAccount { get; set; } 

        [MaxLength(20)]
        public string? PAN { get; set; } 

        [MaxLength(2)]
        public string? DeleteStatus { get; set; } 

        public virtual Cities? Cities { get; set; } 
        public virtual States? States { get; set; } 
        public virtual Countries? Countries { get; set; } 
    }
}
