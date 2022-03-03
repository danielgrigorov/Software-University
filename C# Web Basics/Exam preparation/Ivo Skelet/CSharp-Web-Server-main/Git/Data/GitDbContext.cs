namespace Git.Data
{
    using Git.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class GitDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Commit> Commits { get; set; }
        public DbSet<Repository> Repositories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Git-DanielGrigorov;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                 .Entity<Repository>()
                 .HasOne(r => r.Owner)
                 .WithMany(o => o.Repositories)
                 .HasForeignKey(r => r.OwnerId)
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Entity<Commit>()
                .HasOne(c => c.Creator)
                .WithMany(c => c.Commits)
                .HasForeignKey(c => c.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Entity<Commit>()
                .HasOne(c => c.Repository)
                .WithMany(r => r.Commits)
                .HasForeignKey(c => c.RepositoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
