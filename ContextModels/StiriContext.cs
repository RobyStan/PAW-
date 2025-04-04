using Microsoft.EntityFrameworkCore;

namespace PAW_LAB_4_5.Models
{
    public class StiriContext : DbContext
    {
        public StiriContext(DbContextOptions<StiriContext> options)
            : base(options)
        {
        }

        public DbSet<Stire> Stiri { get; set; }
        public DbSet<Categorie> Categorii { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stire>()
                .HasOne(s => s.Categorie) 
                .WithMany()             
                .HasForeignKey(s => s.CategorieId) 
                .OnDelete(DeleteBehavior.Cascade); 
        }
    }
}