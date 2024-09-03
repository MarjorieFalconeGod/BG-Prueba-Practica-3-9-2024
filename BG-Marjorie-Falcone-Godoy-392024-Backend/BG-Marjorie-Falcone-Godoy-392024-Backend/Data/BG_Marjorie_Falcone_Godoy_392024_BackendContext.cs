using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BG_Marjorie_Falcone_Godoy_392024_Backend;

namespace BG_Marjorie_Falcone_Godoy_392024_Backend.Data
{
    public class BG_Marjorie_Falcone_Godoy_392024_BackendContext : DbContext
    {
        public BG_Marjorie_Falcone_Godoy_392024_BackendContext (DbContextOptions<BG_Marjorie_Falcone_Godoy_392024_BackendContext> options)
            : base(options)
        {
        }

        public DbSet<BG_Marjorie_Falcone_Godoy_392024_Backend.Event> Event { get; set; } = default!;

        public DbSet<BG_Marjorie_Falcone_Godoy_392024_Backend.User>? User { get; set; }

        public DbSet<BG_Marjorie_Falcone_Godoy_392024_Backend.Activity>? Activity { get; set; }

        public DbSet<BG_Marjorie_Falcone_Godoy_392024_Backend.Registration>? Registration { get; set; }
    }
}
