using CarRentalapi.Context;
using CarRentalapi.Models;
using System.Linq;

namespace CarRentalapi.Service
{
    public class CitiesServices
    {
        private readonly MyDbContext _context;

        public CitiesServices(MyDbContext context)
        {
            _context = context;
        }

        public List<Cities> GetAllCities()
        {
            return _context.Cities.ToList();
        }

        public Cities GetCityById(int id)
        {
            return _context.Cities.FirstOrDefault(c => c.CitiesId == id);
        }

        public void AddCity(Cities city)
        {
            _context.Cities.Add(city);
            _context.SaveChanges();
        }

        public void DeleteCity(int id)
        {
            var city = _context.Cities.FirstOrDefault(c => c.CitiesId == id);
            if (city != null)
            {
                _context.Cities.Remove(city);
                _context.SaveChanges();
            }
        }

        public Cities UpdateCity(Cities city)
        {
            var existingCity = _context.Cities.FirstOrDefault(c => c.CitiesId == city.CitiesId);
            if (existingCity != null)
            {
                existingCity.CityName = city.CityName;
                _context.SaveChanges();
            }
            return existingCity;
        }
    }
}
