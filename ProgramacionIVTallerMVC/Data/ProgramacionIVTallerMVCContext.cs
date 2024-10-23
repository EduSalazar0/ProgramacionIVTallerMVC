using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProgramacionIVTallerMVC.Models;

namespace ProgramacionIVTallerMVC.Data
{
    public class ProgramacionIVTallerMVCContext : DbContext
    {
        public ProgramacionIVTallerMVCContext (DbContextOptions<ProgramacionIVTallerMVCContext> options)
            : base(options)
        {
        }

        public DbSet<ProgramacionIVTallerMVC.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<ProgramacionIVTallerMVC.Models.Estadio> Estadio { get; set; } = default!;
        public DbSet<ProgramacionIVTallerMVC.Models.Jugador> Jugador { get; set; } = default!;
    }
}
