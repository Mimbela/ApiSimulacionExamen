using ApiSimulacionExamen.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiSimulacionExamen.Data
{
    public class SimulacionContext:DbContext
    {
        public SimulacionContext() : base("name=cadena") { }

        public DbSet<Doctor> Doctores { get; set; }

        public DbSet<Hospital> Hospitales { get; set; }

    }
}