using Microsoft.EntityFrameworkCore; 
using CarRentalapi.Models;
using OnlineCarRentals.Models;

namespace CarRentalapi.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Cities> Cities { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<States> States { get; set; }
        public DbSet<VehicleMakes> VehicleMakes { get; set; }
        public DbSet<VehicleModels> VehicleModels { get; set; }
        public DbSet<VehicleTypes> VehicleTypes { get; set; }
        public DbSet<VehicleFuel> VehicleFuel { get; set; }
        public DbSet<VehicleCapacity> VehicleCapacity { get; set; }
        public DbSet<Owners> Owners { get; set; }
        public DbSet<Vehicles> Vehicles { get; set; }
        public DbSet<EmployeeTypes> EmployeeTypes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Drivers> Drivers { get; set; }
        public DbSet<Rentals> Rentals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Customers>()
                .HasOne(c => c.Country)
                .WithMany()
                .HasForeignKey(c => c.CountriesId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Customers>()
                .HasOne(c => c.State)
                .WithMany()
                .HasForeignKey(c => c.StatesId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<Drivers>()
                .HasOne(d => d.Country)
                .WithMany()
                .HasForeignKey(d => d.CountriesId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Drivers>()
                .HasOne(d => d.State)
                .WithMany()
                .HasForeignKey(d => d.StatesId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Drivers>()
                .HasOne(d => d.City)
                .WithMany()
                .HasForeignKey(d => d.CitiesId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Employee>()
                .HasIndex(e => e.EmailAddress)
                .IsUnique();

            modelBuilder.Entity<Employee>()
                .HasIndex(e => e.Username)
                .IsUnique();

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Country)
                .WithMany()
                .HasForeignKey(e => e.CountriesId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.City)
                .WithMany()
                .HasForeignKey(e => e.CitiesId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.State)
                .WithMany()
                .HasForeignKey(e => e.StatesId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Owners>()
                .HasOne(o => o.Countries)
                .WithMany()
                .HasForeignKey(o => o.CountriesId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Owners>()
                .HasOne(o => o.Cities)
                .WithMany()
                .HasForeignKey(o => o.CitiesId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Owners>()
                .HasOne(o => o.States)
                .WithMany()
                .HasForeignKey(o => o.StatesId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Rentals>()
                .HasOne(r => r.Customers)
                .WithMany()
                .HasForeignKey(r => r.CustomersId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Rentals>()
                .HasOne(r => r.Vehicles)
                .WithMany()
                .HasForeignKey(r => r.VehiclesId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Rentals>()
                .HasOne(r => r.Drivers)
                .WithMany()
                .HasForeignKey(r => r.DriversId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Rentals>()
                .HasOne(r => r.Employees)
                .WithMany()
                .HasForeignKey(r => r.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Rentals>()
                .HasOne(r => r.SourceCities)
                .WithMany()
                .HasForeignKey(r => r.SourceLocation)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Rentals>()
                .HasOne(r => r.DestinationCities)
                .WithMany()
                .HasForeignKey(r => r.DestinationLocation)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<States>()
                .HasOne(s => s.country)
                .WithMany()
                .HasForeignKey(s => s.CountriesId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<VehicleModels>()
                .HasOne(vm => vm.VehicleMakes)
                .WithMany()
                .HasForeignKey(vm => vm.VehicleMakesId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Vehicles>()
                .HasOne(v => v.Owners)
                .WithMany()
                .HasForeignKey(v => v.OwnersId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Vehicles>()
                .HasOne(v => v.VehicleModels)
                .WithMany()
                .HasForeignKey(v => v.VehicleModelsId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Vehicles>()
                .HasOne(v => v.States)
                .WithMany()
                .HasForeignKey(v => v.RegistrationState)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.EmployeeType)
                .WithMany()
                .HasForeignKey(e => e.EmployeeTypesId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
