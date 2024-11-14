using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalapi.Models
{
    public class Customers
    {
        public int CustomersId { get; set; }

        public string? Name { get; set; }

        public string? EmailAddress { get; set; }

        public string? AddressLine1 { get; set; }

        public string? AddressLine2 { get; set; }

        public int? CitiesId { get; set; } 
        public int? StatesId { get; set; } 
        public string? Pincode { get; set; }

        public int? CountriesId { get; set; } 
        public string? PhoneNumber { get; set; }
        public string? MobileNumber { get; set; }

        public DateTime? RegistrationDate { get; set; }

        public string? Username { get; set; }
        public string? Password { get; set; }

        public DateTime? LastLogin { get; set; }

        public string? DeleteStatus { get; set; }

        public virtual Cities? City { get; set; }
        public virtual States? State { get; set; }
        public virtual Countries? Country { get; set; }
    }
}
