using AgroTour_AggregateRoot.Entities;
using AgroTour_Repository.Data;
using AgroTour_Service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AgroTour_Repository.Repository
{
    public class LocationRepository : ILocationRepository
    {
        private readonly ApplicationDbContext _db;
        private string? includeProperties;

        // Constructor
        public LocationRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        // Add a new Location
        public void Add(Location location)
        {
            _db.Add(location);
        }

        // Save changes to the database
        public void Save()
        {
            _db.SaveChanges();
        }

        public Location Get(Expression<Func<Location, bool>>? filter)
        {
            IQueryable<Location> query = _db.Set<Location>();

            // Apply the filter if provided
            if (filter != null)
            {
                query = query.Where(filter);
            }

            // Include related entities if specified
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }

            // Return the first matching location or null
            return query.FirstOrDefault();
        }
    }
}
