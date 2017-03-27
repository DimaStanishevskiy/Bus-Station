using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buses_station.Class
{
    public class Journey
    {
        public int journeyId { set; get; }
        public Route route { set; get; }
        public Bus bus { set; get; }
        public DateTime departureTime { set; get; }


    }
}
