using Microsoft.EntityFrameworkCore;

namespace CompetitionManagement.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }
        public DbSet<Team> team => Set<Team>();
        public DbSet<User> user => Set<User>();
        public DbSet<Role> role => Set<Role>();

        public DbSet<User_Team> User_Team => Set<User_Team>();
        public DbSet<User_Role> User_Role => Set<User_Role>();



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User_Team>()
           .HasKey(i => new { i.userId, i.teamId });

            modelBuilder.Entity<User_Role>()
                .HasKey(i => new { i.userId, i.roleId });

            modelBuilder.Entity<User_Team>()
        .HasOne(x => x.user)
        .WithMany(y => y.User_Team)
        .HasForeignKey(f => f.userId)
        .IsRequired()
        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User_Team>()
                .HasOne(o => o.team)
                .WithMany(m => m.User_Team)
                .HasForeignKey(f => f.teamId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<User_Role>()
        .HasOne(x => x.user)
        .WithMany(y => y.User_Role)
        .HasForeignKey(f => f.userId)
        .IsRequired()
        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User_Role>()
                .HasOne(o => o.role)
                .WithMany(m => m.User_Role)
                .HasForeignKey(f => f.roleId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
