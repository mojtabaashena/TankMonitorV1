using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TankMonitorV1.Models
{
    public class Station
    {
        public int Id { get; set; }

        public int GSID { get; set; }

        public string GSName { get; set; }

        public string Address { get; set; }

        public string Location { get; set; }


    }
}
