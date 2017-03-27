using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buses_station.Class
{
    public class BusStopsOnRoute
    {
        public int busStopsOnRouteId { set; get; }
        public Route route { set; get; }
        public BusStop busStop { set; get; }
        public int travelTime { set; get; }
    }
}
