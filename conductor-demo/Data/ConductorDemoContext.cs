using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using conductor.demo.Models;

    public class ConductorDemoContext : DbContext
    {
        public ConductorDemoContext (DbContextOptions<ConductorDemoContext> options)
            : base(options)
        {
        }

        public DbSet<conductor.demo.Models.MaquinaVirtual> MaquinaVirtual { get; set; }
    }
