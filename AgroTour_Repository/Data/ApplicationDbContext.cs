using AgroTour_AggregateRoot.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroTour_Repository.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base (options)
        {
              
        }
        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Location>().HasData(
                new Location
                {
                    Id =1,
                    locationName = "National Museum",
                    LocationAddress = "ShaBhag",
                    LocationCity = "Dhaka",
                    Cost=100,
                    Capacity=500,
                 },

                new Location
                {
                    Id = 2,
                    locationName = "ZOO",
                    LocationAddress = "Mirpur-1",
                    LocationCity = "Dhaka",
                    Cost = 50,
                    Capacity = 1000,
                },

                new Location
                {
                    Id = 3,
                    locationName = "National Military Museum",
                    LocationAddress = "Bijoy Soroni",
                    LocationCity = "Dhaka",
                    Cost = 100,
                    Capacity = 500,
                } );

        }
    }
}
