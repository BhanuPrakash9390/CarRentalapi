using CarRentalapi.Context;
using Microsoft.AspNetCore.Http.HttpResults;
using OnlineCarRentals.Models;

namespace CarRentalapi.Service
{
    public class OwnersServices
    {
        private readonly MyDbContext _context;
        public OwnersServices(MyDbContext dbContext)
        {
            _context = dbContext;
        }
        public List<Owners> GetAllOwners()
        {
            return _context.Owners.ToList();
        }
        public Owners GetOwnerById(int id)
        {
            return _context.Owners.FirstOrDefault(c=>c.OwnersId==id);
        }
        public void AddOwner(Owners owner)
        {
            _context.Owners.Add(owner);
            _context.SaveChanges();
        }
        public void DeleteOwner(int id)
        {
            var owner = _context.Owners.FirstOrDefault(c=>c.OwnersId== id);
            if(owner!=null)
            {
                _context.Owners.Remove(owner);
                _context.SaveChanges();
            }
        }
        public Owners UpdateOwner(Owners owner)
        {
            var updateowner = _context.Owners.FirstOrDefault(c => c.OwnersId == owner.OwnersId);
            if(updateowner!=null)
            {
                updateowner.Name= owner.Name;
                updateowner.Address1 = owner.Address1;
                updateowner.Address2 = owner.Address2;
                updateowner.PinCode= owner.PinCode;
                updateowner.PhoneNumber= owner.PhoneNumber;
                updateowner.MobileNumber= owner.MobileNumber;
                updateowner.BankAccount= owner.BankAccount;
                updateowner.BankName= owner.BankName;
                updateowner.PAN= owner.PAN;
                _context.SaveChanges();
            }
            return updateowner;
        }
    }
}
