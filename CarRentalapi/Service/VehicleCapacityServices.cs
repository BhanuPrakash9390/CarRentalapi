using CarRentalapi.Context;
using CarRentalapi.Models;
using System.Linq;

namespace CarRentalapi.Service
{
    public class VehicleCapacityServices
    {
        private readonly MyDbContext _context;

        public VehicleCapacityServices(MyDbContext context)
        {
            _context = context;
        }

        public List<VehicleCapacity> GetAllVehicleCapacities()
        {
            return _context.VehicleCapacity.ToList();
        }

        public VehicleCapacity GetVehicleCapacityById(int id)
        {
            return _context.VehicleCapacity.FirstOrDefault(v => v.VehicleCapacityId == id);
        }

        public void AddVehicleCapacity(VehicleCapacity vehicleCapacity)
        {
            _context.VehicleCapacity.Add(vehicleCapacity);
            _context.SaveChanges();
        }

        public void DeleteVehicleCapacity(int id)
        {
            var vehicleCapacity = _context.VehicleCapacity.FirstOrDefault(v => v.VehicleCapacityId == id);
            if (vehicleCapacity != null)
            {
                _context.VehicleCapacity.Remove(vehicleCapacity);
                _context.SaveChanges();
            }
        }

        public VehicleCapacity UpdateVehicleCapacity(VehicleCapacity vehicleCapacity)
        {
            var existingVehicleCapacity = _context.VehicleCapacity.FirstOrDefault(v => v.VehicleCapacityId == vehicleCapacity.VehicleCapacityId);
            if (existingVehicleCapacity != null)
            {
                existingVehicleCapacity.Capacity = vehicleCapacity.Capacity;
                _context.SaveChanges();
            }
            return existingVehicleCapacity;
        }
    }
}
