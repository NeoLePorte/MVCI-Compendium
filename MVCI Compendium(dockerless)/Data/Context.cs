using Microsoft.EntityFrameworkCore;
using MVCI_Compendium.Models;
using MVCI_Compendium.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCI_Compendium.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Combo> Combos { get; set; }
        public DbSet<MoveModel> Moves { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }






    }   

    
}

