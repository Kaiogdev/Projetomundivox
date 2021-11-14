using CopaDeVerdade.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaDeVerdade.Database
{
    public class CopaContext : DbContext
    {
        public CopaContext(DbContextOptions<CopaContext> options) : base(options){}

        public DbSet<Time> Times { get; set; }
    }
}
