using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Buses_station.Class
{
    public class Contexts : DbContext
    {
        public Contexts() : base("DbConnection")
        { }

        public DbSet<Bus> Buses { set; get; }
        public DbSet<BusStopsOnRoute> StopsOnRoutes { set; get; }
        public DbSet<BusStop> BusStops { set; get; }
        public DbSet<Journey> Journeys { set; get; }
        public DbSet<Route> Routes { set; get; }
    }

    public class BusContext : DbContext
    {
        public BusContext() : base("DbConnection")
        { }

        public DbSet<Bus> Buses { set; get; }
    }
}
