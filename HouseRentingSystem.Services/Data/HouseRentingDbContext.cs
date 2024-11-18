using Microsoft.EntityFrameworkCore;
using HouseRentingSystem.Services.Data.Entities;

namespace HouseRentingSystem.Services.Data
{
    public class HouseRentingDbContext : DbContext
    {
        public HouseRentingDbContext(DbContextOptions<HouseRentingDbContext> options)
            : base(options)
        {
        }

        // DbSets representing the tables in the database
        public DbSet<House> Houses { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure House entity
            modelBuilder.Entity<House>(static entity =>
            {
                entity.HasKey(h => h.Id);

                entity.Property(h => h.Title)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(h => h.Address)
                      .IsRequired()
                      .HasMaxLength(200);

                entity.Property(h => h.PricePerMonth)
                      .IsRequired();


                entity.HasOne(h => h.Agent)
                      .WithMany(a => a.Houses)
                      .HasForeignKey(h => h.AgentId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(h => h.Renter)
                      .WithMany(u => u.RentedHouses)
                      .HasForeignKey(h => h.RenterId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            // Configure Agent entity
            modelBuilder.Entity<Agent>(entity =>
            {
                entity.HasKey(a => a.Id);

                entity.HasOne(a => a.User)
                      .WithOne()
                      .HasForeignKey<Agent>(a => a.UserId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // Configure User entity
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.Id);

                entity.Property(u => u.FirstName)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(u => u.LastName)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(u => u.Email)
                      .IsRequired()
                      .HasMaxLength(100);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(c => c.Id);

                entity.Property(c => c.Name)
                    .IsRequired()
                    .HasMaxLength(50);

            });
        }
    }
}