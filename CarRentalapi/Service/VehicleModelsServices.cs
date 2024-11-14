using CarRentalapi.Context;
using CarRentalapi.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CarRentalapi.Service
{
    public class VehicleModelsServices
    {
        private readonly MyDbContext _context;

        public VehicleModelsServices(MyDbContext context)
        {
            _context = context;
        }

        public List<VehicleModels> GetAllVehicleModels()
        {
            return _context.VehicleModels.Include(v => v.VehicleMakes).ToList();
        }

        public VehicleModels GetVehicleModelById(int id)
        {
            return _context.VehicleModels.Include(v => v.VehicleMakes).FirstOrDefault(v => v.VehicleModelsId == id);
        }

        public void AddVehicleModel(VehicleModels vehicleModel)
        {
            _context.VehicleModels.Add(vehicleModel);
            _context.SaveChanges();
        }

        public void DeleteVehicleModel(int id)
        {
            var vehicleModel = _context.VehicleModels.FirstOrDefault(v => v.VehicleModelsId == id);
            if (vehicleModel != null)
            {
                _context.VehicleModels.Remove(vehicleModel);
                _context.SaveChanges();
            }
        }

        public VehicleModels UpdateVehicleModel(VehicleModels vehicleModel)
        {
            var existingVehicleModel = _context.VehicleModels.FirstOrDefault(v => v.VehicleModelsId == vehicleModel.VehicleModelsId);
            if (existingVehicleModel != null)
            {
                existingVehicleModel.Name = vehicleModel.Name;
                _context.SaveChanges();
            }
            return existingVehicleModel;
        }
    }
}
