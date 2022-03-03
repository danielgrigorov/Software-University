namespace FootballManager.Data
{
    using Microsoft.EntityFrameworkCore;

    using FootballManager.Data.Models;

    public class FootballManagerDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<UserPlayer> UserPlayers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(@"Server=.\SQLEXPRESS;Database=FootballManager-DaniGri;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserPlayer>(entity =>
            {
                entity.HasKey(sc => new { sc.PlayerId, sc.UserId });
                entity
                .HasOne(sc => sc.User)
                .WithMany(s => s.UserPlayers)
                .HasForeignKey(sc => sc.UserId);
            });

        }
    }
}
