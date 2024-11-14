using CarRentalapi.Context;
using CarRentalapi.Models;
using OnlineCarRentals.Models;
using System.Linq;

namespace CarRentalapi.Service
{
    public class RentalsServices
    {
        private readonly MyDbContext _context;

        public RentalsServices(MyDbContext context)
        {
            _context = context;
        }

        // Get all rentals
        public List<Rentals> GetAllRentals()
        {
            return _context.Rentals.ToList();
        }

        // Get rental by ID
        public Rentals GetRentalById(int id)
        {
            return _context.Rentals.FirstOrDefault(r => r.RentalsId == id);
        }

        // Add a new rental
        public void AddRental(Rentals rental)
        {
            _context.Rentals.Add(rental);
            _context.SaveChanges();
        }

        // Delete a rental by ID
        public void DeleteRental(int id)
        {
            var rental = _context.Rentals.FirstOrDefault(r => r.RentalsId == id);
            if (rental != null)
            {
                _context.Rentals.Remove(rental);
                _context.SaveChanges();
            }
        }

        // Update an existing rental
        public Rentals UpdateRental(Rentals rental)
        {
            var existingRental = _context.Rentals.FirstOrDefault(r => r.RentalsId == rental.RentalsId);
            if (existingRental != null)
            {
                existingRental.ReservationDate = rental.ReservationDate;
                existingRental.VehicleRate = rental.VehicleRate;
                existingRental.NoOfDays = rental.NoOfDays;
                existingRental.StartDate = rental.StartDate;
                existingRental.EndDate = rental.EndDate;
                existingRental.NoOfKMS = rental.NoOfKMS;
                existingRental.StartKMS = rental.StartKMS;
                existingRental.EndKMS = rental.EndKMS;
                existingRental.SourceLocation = rental.SourceLocation;
                existingRental.DestinationLocation = rental.DestinationLocation;
                existingRental.TravelPurpose = rental.TravelPurpose;
                existingRental.Amount = rental.Amount;
                existingRental.TransactionNumber = rental.TransactionNumber;

                _context.SaveChanges();
            }
            return existingRental;
        }

        public List<Rentals> GetRentalsByCustomerId(int customerId)
        {
            return _context.Rentals.Where(r => r.CustomersId == customerId).ToList();
        }

        public List<Rentals> GetRentalsByVehicleId(int vehicleId)
        {
            return _context.Rentals.Where(r => r.VehiclesId == vehicleId).ToList();
        }

        public List<Rentals> GetRentalsByDateRange(DateTime startDate, DateTime endDate)
        {
            return _context.Rentals.Where(r => r.StartDate >= startDate && r.EndDate <= endDate).ToList();
        }
    }
}
