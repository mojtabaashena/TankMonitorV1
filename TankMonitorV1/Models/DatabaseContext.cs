using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TankMonitorV1.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {

        }

        public DbSet<Station> tblStations { get; set; }

        public DbSet<Tank> tblTanks { get; set; }

    }
}
