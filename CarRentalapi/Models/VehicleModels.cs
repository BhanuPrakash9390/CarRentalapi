namespace CarRentalapi.Models
{
    public class VehicleModels
    {
        public int VehicleModelsId { get; set; }

        public int VehicleMakesId { get; set; }

        public string? Name { get; set; }

        public virtual VehicleMakes? VehicleMakes { get; set; }
    }
}
