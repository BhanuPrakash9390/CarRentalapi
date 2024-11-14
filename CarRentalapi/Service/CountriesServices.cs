using CarRentalapi.Context;
using CarRentalapi.Models;

namespace CarRentalapi.Service
{
    public class CountriesServices
    {
        private readonly MyDbContext context;
        public CountriesServices(MyDbContext myDbContext)
        {
            context = myDbContext;
        }

        public List<Countries> GetAllCountries()
        {
            var countrylist=context.Countries.ToList();
            return countrylist;
        }
        public Countries GetCountryById(int id)
        {
            var country=context.Countries.FirstOrDefault(c=>c.CountriesId==id);
            return country;
        }

        public void AddCountries(Countries countries)
        {
            context.Countries.Add(countries);
            context.SaveChanges();
        }
        public void DeleteCountries(int id)
        {
            var countriesdel=context.Countries.FirstOrDefault(c=>c.CountriesId==id);
            if (countriesdel != null)
            {
                context.Countries.Remove(countriesdel);
                context.SaveChanges();
            }
        }
        public Countries UpdateCountries(Countries countries)
        {
            var countryupdate=context.Countries.FirstOrDefault(c=>c.CountriesId==countries.CountriesId);
            if (countryupdate != null)
            {
                countryupdate.CountryName = countries.CountryName;
                context.SaveChanges();
            }
            return countryupdate;
        }

    }
}
