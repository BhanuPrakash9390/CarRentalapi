using CarRentalapi.Models;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineCarRentals.Models
{
    public class Vehicles
    {
        public int VehiclesId { get; set; } 

        public int OwnersId { get; set; } 

        public int VehicleModelsId { get; set; } 

        [MaxLength(40)]
        public string? Type { get; set; } 

        public int Year { get; set; } 

        [MaxLength(40)]
        public string? Color { get; set; } 

        [MaxLength(20)]
        public string? Fuel { get; set; } 

        public int Capacity { get; set; } 

        public int Mileage { get; set; } 

        public byte[]? Picture { get; set; } 

        [MaxLength(20)]
        public string? RegistrationNumber { get; set; } 

        [ForeignKey("States")]
        public int? RegistrationState { get; set; } 

        [MaxLength(25)]
        public string? ChaisisNumber { get; set; } 

        public int DailyRate { get; set; } 

        public int? HourlyRate { get; set; } 

        public int? AdditionalDailyRate { get; set; } 

        public int? AdditionalHourlyRate { get; set; }

        [MaxLength(2)]
        [DefaultValue(null)]
        public string? DeleteStatus { get; set; } 


        public virtual Owners? Owners { get; set; }
        public virtual VehicleModels? VehicleModels { get; set; }
        public virtual States? States { get; set; }
        public virtual Cities? Cities { get; set; } 
        public virtual Countries? Countries { get; set; } 
    }
}
