using JobApplicationTrackerApi.Domain;
using Microsoft.EntityFrameworkCore;

namespace JobApplicationTrackerApi.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<JobApplication> JobApplications { get; set; }
        public DbSet<JobApplicationPhase> Phases { get; set; }
        public DbSet<JobApplicationStatus> Status { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<JobApplication>()
                .HasKey(j => j.Id);

            modelBuilder.Entity<JobApplication>()
                .Property(e => e.Salary)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<JobApplication>()
                .HasOne(j => j.User)
                .WithMany(u => u.JobApplications)
                .HasForeignKey(j => j.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<JobApplicationPhase>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<JobApplicationStatus>()
                .HasKey(s => s.Id);
        }
    }
}
