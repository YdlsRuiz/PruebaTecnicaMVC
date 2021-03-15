using Microsoft.EntityFrameworkCore;
using PruebaTecnicaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnicaMVC.Data
{
    public class AplicacionDbContext: DbContext
    {
        public AplicacionDbContext(DbContextOptions<AplicacionDbContext>options): base(options)
        {

        }

        public DbSet<Persona> Persona { get; set; }
    }
}
