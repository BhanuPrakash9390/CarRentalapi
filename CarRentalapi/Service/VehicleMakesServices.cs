using CarRentalapi.Context;
using CarRentalapi.Models;

namespace CarRentalapi.Service
{
    public class VehicleMakesServices
    {
        private readonly MyDbContext _context;

        public VehicleMakesServices(MyDbContext context)
        {
            _context = context;
        }

        public List<VehicleMakes> GetAllVehicleMakes()
        {
            return _context.VehicleMakes.ToList();
        }

        public VehicleMakes GetVehicleMakeById(int id)
        {
            return _context.VehicleMakes.FirstOrDefault(v => v.VehicleMakesId == id);
        }

        public void AddVehicleMake(VehicleMakes vehicleMake)
        {
            _context.VehicleMakes.Add(vehicleMake);
            _context.SaveChanges();
        }

        public void DeleteVehicleMake(int id)
        {
            var vehicleMake = _context.VehicleMakes.FirstOrDefault(v => v.VehicleMakesId == id);
            if (vehicleMake != null)
            {
                _context.VehicleMakes.Remove(vehicleMake);
                _context.SaveChanges();
            }
        }

        public VehicleMakes UpdateVehicleMake(VehicleMakes vehicleMake)
        {
            var existingVehicleMake = _context.VehicleMakes.FirstOrDefault(v => v.VehicleMakesId == vehicleMake.VehicleMakesId);
            if (existingVehicleMake != null)
            {
                existingVehicleMake.Name = vehicleMake.Name;
                _context.SaveChanges();
            }
            return existingVehicleMake;
        }
    }
}
