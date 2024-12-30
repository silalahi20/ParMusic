// Data/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using ParMusic.API.Models;

namespace ParMusic.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Instrument> Instruments { get; set; } = null!;
        public DbSet<UserPreference> UserPreferences { get; set; } = null!;
        public DbSet<Rating> Ratings { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserPreference>()
                .HasOne(p => p.User)
                .WithMany(u => u.Preferences)
                .HasForeignKey(p => p.UserId);

            modelBuilder.Entity<Rating>()
                .HasOne(r => r.User)
                .WithMany()
                .HasForeignKey(r => r.UserId);

            modelBuilder.Entity<Rating>()
                .HasOne(r => r.Instrument)
                .WithMany()
                .HasForeignKey(r => r.InstrumentId);
        }
    }
}