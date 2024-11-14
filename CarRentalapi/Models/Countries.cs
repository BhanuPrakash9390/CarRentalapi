namespace CarRentalapi.Models
{
    public class Countries
    {
        public int CountriesId { get; set; }

        public string? CountryName { get; set; }

        public ICollection<States>? States { get; set; }
    }
}
