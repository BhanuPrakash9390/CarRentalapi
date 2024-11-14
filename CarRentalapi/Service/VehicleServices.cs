using CarRentalapi.Context;
using CarRentalapi.Models;
using Microsoft.EntityFrameworkCore;
using OnlineCarRentals.Models;
using System.Linq;

namespace CarRentalapi.Service
{
    public class VehicleServices
    {
        private readonly MyDbContext _context;

        public VehicleServices(MyDbContext context)
        {
            _context = context;
        }

        public List<Vehicles> GetAllVehicles()
        {
            return _context.Vehicles.Include(v => v.VehicleModels).Include(v => v.Owners).Include(v => v.States).Include(v => v.Cities).Include(v => v.Countries).ToList();
        }

        public Vehicles GetVehicleById(int id)
        {
            return _context.Vehicles.Include(v => v.VehicleModels).Include(v => v.Owners).Include(v => v.States).Include(v => v.Cities).Include(v => v.Countries).FirstOrDefault(v => v.VehiclesId == id);
        }

        public void AddVehicle(Vehicles vehicle)
        {
            _context.Vehicles.Add(vehicle);
            _context.SaveChanges();
        }

        public Vehicles UpdateVehicle(Vehicles vehicle)
        {
            var existingVehicle = _context.Vehicles.FirstOrDefault(v => v.VehiclesId == vehicle.VehiclesId);
            if (existingVehicle != null)
            {
                existingVehicle.Type = vehicle.Type;
                existingVehicle.Year = vehicle.Year;
                existingVehicle.Color = vehicle.Color;
                existingVehicle.Fuel = vehicle.Fuel;
                existingVehicle.Capacity = vehicle.Capacity;
                existingVehicle.Mileage = vehicle.Mileage;
                existingVehicle.Picture = vehicle.Picture;
                existingVehicle.RegistrationNumber = vehicle.RegistrationNumber;
                existingVehicle.RegistrationState = vehicle.RegistrationState;
                existingVehicle.ChaisisNumber = vehicle.ChaisisNumber;
                existingVehicle.DailyRate = vehicle.DailyRate;
                existingVehicle.HourlyRate = vehicle.HourlyRate;
                existingVehicle.AdditionalDailyRate = vehicle.AdditionalDailyRate;
                existingVehicle.AdditionalHourlyRate = vehicle.AdditionalHourlyRate;

                _context.SaveChanges();
            }
            return existingVehicle;
        }

        public void DeleteVehicle(int id)
        {
            var vehicle = _context.Vehicles.FirstOrDefault(v => v.VehiclesId == id);
            if (vehicle != null)
            {
                _context.Vehicles.Remove(vehicle);
                _context.SaveChanges();
            }
        }
    }
}
