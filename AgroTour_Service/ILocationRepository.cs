using AgroTour_AggregateRoot.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AgroTour_Service
{
    public interface ILocationRepository
    {
        Location Get(Expression<Func<Location, bool>>? filter);
        void Add(Location location);
        void Save();
    }
}
