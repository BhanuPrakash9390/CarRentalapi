using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentalapi.Models
{
    public class States
    {
        public int StatesId { get; set; }

        [ForeignKey("country")]
        public int CountriesId { get; set; }

        public string? StatesName { get; set;}

        public Countries? country { get; set; }

        public ICollection<Cities>? Cities { get; set; }

    }
}
