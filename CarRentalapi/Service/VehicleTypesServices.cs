using CarRentalapi.Context;
using CarRentalapi.Models;
using System.Linq;

namespace CarRentalapi.Service
{
    public class VehicleTypesServices
    {
        private readonly MyDbContext _context;

        public VehicleTypesServices(MyDbContext context)
        {
            _context = context;
        }

        public List<VehicleTypes> GetAllVehicleTypes()
        {
            return _context.VehicleTypes.ToList();
        }

        public VehicleTypes GetVehicleTypeById(int id)
        {
            return _context.VehicleTypes.FirstOrDefault(vt => vt.VehicleTypesId == id);
        }

        public void AddVehicleType(VehicleTypes vehicleType)
        {
            _context.VehicleTypes.Add(vehicleType);
            _context.SaveChanges();
        }

        public VehicleTypes UpdateVehicleType(VehicleTypes vehicleType)
        {
            var existingVehicleType = _context.VehicleTypes.FirstOrDefault(vt => vt.VehicleTypesId == vehicleType.VehicleTypesId);
            if (existingVehicleType != null)
            {
                existingVehicleType.Type = vehicleType.Type;
                _context.SaveChanges();
            }
            return existingVehicleType;
        }

        public void DeleteVehicleType(int id)
        {
            var vehicleType = _context.VehicleTypes.FirstOrDefault(vt => vt.VehicleTypesId == id);
            if (vehicleType != null)
            {
                _context.VehicleTypes.Remove(vehicleType);
                _context.SaveChanges();
            }
        }
    }
}
