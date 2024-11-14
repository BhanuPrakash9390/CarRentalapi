using CarRentalapi.Context;
using CarRentalapi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CarRentalapi.Service
{
    public class CustomersServices
    {
        private readonly MyDbContext _context;

        public CustomersServices(MyDbContext context)
        {
            _context = context;
        }

        // Get all customers
        public List<Customers> GetAllCustomers()
        {
            return _context.Customers
                           .Include(c => c.City)  
                           .Include(c => c.State)
                           .Include(c => c.Country)
                           .ToList();
        }

        public Customers GetCustomerById(int id)
        {
            return _context.Customers.Include(c => c.City).Include(c => c.State).Include(c => c.Country).FirstOrDefault(c => c.CustomersId == id);
        }

        public void AddCustomer(Customers customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            var customer = _context.Customers
                                    .FirstOrDefault(c => c.CustomersId == id);

            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }

        public Customers UpdateCustomer(Customers customer)
        {
            var existingCustomer = _context.Customers
                                           .FirstOrDefault(c => c.CustomersId == customer.CustomersId);

            if (existingCustomer != null)
            {
                existingCustomer.Name = customer.Name;
                existingCustomer.EmailAddress = customer.EmailAddress;
                existingCustomer.AddressLine1 = customer.AddressLine1;
                existingCustomer.AddressLine2 = customer.AddressLine2;
                existingCustomer.Pincode = customer.Pincode;
                existingCustomer.PhoneNumber = customer.PhoneNumber;
                existingCustomer.MobileNumber = customer.MobileNumber;
                existingCustomer.Username = customer.Username;
                existingCustomer.Password = customer.Password;

                _context.SaveChanges();

            }
            return existingCustomer;
        }
    }
}
