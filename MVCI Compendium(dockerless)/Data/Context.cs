using Microsoft.EntityFrameworkCore;
using MVCI_Compendium.Models;

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
            modelBuilder.Entity<MoveInput>(t =>
            {
                t.HasKey(x => new { x.MoveId, x.InputValue });
            });
            modelBuilder.Entity<ComboInput>(t =>
            {
                t.HasKey(x => new { x.ComboId, x.InputValue });
            });
        }






    }   

    
}

