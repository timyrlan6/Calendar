using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Calendar.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<EventType> EventTypes => Set<EventType>();
        public DbSet<Booking> Bookings => Set<Booking>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>(entity =>
            {
                entity.HasIndex(e => e.BookingLinkId).IsUnique();

                entity.Property(e => e.BookingLinkId)
                    .ValueGeneratedNever();
            });

            builder.Entity<EventType>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasIndex(e => e.OwnerId);
                entity.HasIndex(e => e.BookingLinkId);

                entity.HasOne(e => e.Owner)
                    .WithMany(u => u.EventTypes)
                    .HasForeignKey(e => e.OwnerId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            builder.Entity<Booking>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.HasIndex(e => e.BookingLinkId);

                entity.HasOne(e => e.Owner)
                    .WithMany(u => u.Bookings)
                    .HasForeignKey(e => e.OwnerId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}