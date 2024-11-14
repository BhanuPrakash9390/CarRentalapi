namespace CarRentalapi.Models
{
    public class Cities
    {
        public int CitiesId {  get; set; }
        public int StatesId { get; set; }

        public string ?CityName { get; set; }

        public States ?States { get; set; }
    }
}
