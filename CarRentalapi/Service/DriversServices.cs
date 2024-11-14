using CarRentalapi.Context;
using CarRentalapi.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace CarRentalapi.Service
{
    public class DriversServices
    {
        private readonly MyDbContext _context;
        public DriversServices(MyDbContext context)
        {
            _context = context;
        }
        public List<Drivers> GetAllDrivers()
        {
            return _context.Drivers.ToList();
        }
        public Drivers GetDriversById(int id)
        {
            return _context.Drivers.FirstOrDefault(x => x.DriversId == id);
        }
        public void AddDriver(Drivers driver)
        {
            _context.Drivers.Add(driver);
            _context.SaveChanges();
        }
        public void DeleteDrivers(int id)
        {
            var driver=_context.Drivers.FirstOrDefault(x=>x.DriversId == id);
            if (driver != null)
            {
                _context.Drivers.Remove(driver);
                _context.SaveChanges();
            }
        }
        public Drivers UpdateDrivers(Drivers drivers)
        {
            var exitingdrivers=_context.Drivers.FirstOrDefault(x=>x.DriversId==drivers.DriversId);
            if(exitingdrivers != null)
            {
                exitingdrivers.Name=drivers.Name;
                exitingdrivers.LicenceNumber=drivers.LicenceNumber;
                exitingdrivers.AddressLine1=drivers.AddressLine1;
                exitingdrivers.AddressLine2=drivers.AddressLine2;
                exitingdrivers.Pincode=drivers.Pincode;
                exitingdrivers.PhoneNumber=drivers.PhoneNumber;
                exitingdrivers.MobileNumber=drivers.MobileNumber;
                exitingdrivers.BankName=drivers.BankName;
                exitingdrivers.BankAccount=drivers.BankAccount;
                exitingdrivers.PAN=drivers.PAN;
                _context.SaveChanges();
            }
            return exitingdrivers;
        }
    }
}
