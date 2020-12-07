using MemberDemo.Models.Classes;
using Microsoft.EntityFrameworkCore;

namespace MemberDemo.Models
{
    public class LogDemoDbContext : DbContext
    {
        public LogDemoDbContext(DbContextOptions<LogDemoDbContext>options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Countries Data Test
            modelBuilder.Entity<Country>().HasData(new Country
            {
                Id = 1,
                CountryName = "US"
            },
            new Country
            {
                Id = 2,
                CountryName = "UK"
            },
            new Country
            {
                Id = 3,
                CountryName = "Egypt"
            },
            new Country
            {
                Id = 4,
                CountryName = "Saudi Arabia"
            });
            #endregion

            #region Cities Data Test
            modelBuilder.Entity<City>().HasData(
                    new City { Id = 1, CityName = "Makka", CountryId = 4 },
                    new City { Id = 2, CityName = "Maddinh", CountryId = 4 },
                    new City { Id = 3, CityName = "Riyadh", CountryId = 4 },
                    new City { Id = 4, CityName = "Damam", CountryId = 4 },
                    new City { Id = 5, CityName = "Mansoura", CountryId = 3 },
                    new City { Id = 6, CityName = "Cairo", CountryId = 3 },
                    new City { Id = 7, CityName = "Mahala", CountryId = 3 },
                    new City { Id = 8, CityName = "Alex", CountryId = 3 },
                    new City { Id = 9, CityName = "NewYourk", CountryId = 1 },
                    new City { Id = 10, CityName = "LA", CountryId = 1 },
                    new City { Id = 11, CityName = "Vigase", CountryId = 1 },
                    new City { Id = 12, CityName = "Maiamy", CountryId = 1 },
                    new City { Id = 13, CityName = "London", CountryId = 2 },
                    new City { Id = 14, CityName = "Manchester", CountryId = 2 },
                    new City { Id = 15, CityName = "Edinburgh", CountryId = 2 },
                    new City { Id = 16, CityName = "Birmingham", CountryId = 2 },
                    new City { Id = 17, CityName = "Glasgow", CountryId = 2 },
                    new City { Id = 18, CityName = "Cardiff", CountryId = 2 },
                    new City { Id = 19, CityName = "Belfast", CountryId = 2 }
                    );
            #endregion

            #region Admin Data
            modelBuilder.Entity<Admin>().HasData(
                new Admin { AdminID = 1, FirstName = "Mohamed", LastName = "Hamis", AdminEmail = "hamis@gmail.com", Password = "M:a:2737417" });
            #endregion
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
