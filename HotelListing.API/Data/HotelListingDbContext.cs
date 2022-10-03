using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data;

public class HotelListingDbContext: DbContext
{
    public HotelListingDbContext(DbContextOptions options) : base(options)
    {
        
    }
    
    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<Country> Countries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Country>().HasData(
            new Country
            {
                Id   = 1,
                Name = "Jamaica",
                ShortName = "JM"
            },
            new Country
            {
                Id = 2,
                Name = "Bahamas",
                ShortName = "BS"
            },
            new Country
            {
                Id = 3,
                Name = "Cayan Island",
                ShortName = "CI"
            }
        );
        modelBuilder.Entity<Hotel>().HasData(
            new Hotel
            {
                Id   = 1,
                Name = "Hotel 1",
                Address = "Concepción",
                Rating = 4,
                CountryID = 1
            },
            new Hotel
            {
                Id   = 2,
                Name = "Hotel 2",
                Address = "Santiago",
                Rating = 9.4,
                CountryID = 2
            },
            new Hotel
            {
                Id   = 3,
                Name = "Hotel 3",
                Address = "Viña del mar",
                Rating = 6,
                CountryID = 3
            }
        );
    }
}