using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buses_station.Class
{
    public class Bus
    {
        public int busId { set; get; }
        public string busNumber { set; get; }
        public string model { set; get; }

        public override string ToString()
        {
            return busNumber;
        }
    }
}

