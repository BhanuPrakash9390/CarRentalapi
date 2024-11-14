using CarRentalapi.Context;
using CarRentalapi.Models;
using System.Linq;

namespace CarRentalapi.Service
{
    public class VehicleFuelServices
    {
        private readonly MyDbContext _context;

        public VehicleFuelServices(MyDbContext context)
        {
            _context = context;
        }

        public List<VehicleFuel> GetAllVehicleFuels()
        {
            return _context.VehicleFuel.ToList();
        }

        public VehicleFuel GetVehicleFuelById(int id)
        {
            return _context.VehicleFuel.FirstOrDefault(v => v.VehicleFuelId == id);
        }

        public void AddVehicleFuel(VehicleFuel vehicleFuel)
        {
            _context.VehicleFuel.Add(vehicleFuel);
            _context.SaveChanges();
        }

        public void DeleteVehicleFuel(int id)
        {
            var vehicleFuel = _context.VehicleFuel.FirstOrDefault(v => v.VehicleFuelId == id);
            if (vehicleFuel != null)
            {
                _context.VehicleFuel.Remove(vehicleFuel);
                _context.SaveChanges();
            }
        }

        public VehicleFuel UpdateVehicleFuel(VehicleFuel vehicleFuel)
        {
            var existingVehicleFuel = _context.VehicleFuel.FirstOrDefault(v => v.VehicleFuelId == vehicleFuel.VehicleFuelId);
            if (existingVehicleFuel != null)
            {
                existingVehicleFuel.Fuel = vehicleFuel.Fuel;
                _context.SaveChanges();
            }
            return existingVehicleFuel;
        }
    }
}
