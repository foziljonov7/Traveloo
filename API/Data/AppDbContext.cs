using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Human> Humans { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Human
            modelBuilder.Entity<Human>()
                .HasKey(h => h.Id);
            modelBuilder.Entity<Human>()
                .Property(h => h.Firstname)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<Human>()
                .Property(h => h.Lastname)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<Human>()
                .Property(h => h.Age)
                .IsRequired();
            modelBuilder.Entity<Human>()
                .Property(h => h.Location)
                .HasMaxLength(128)
                .IsRequired();
            modelBuilder.Entity<Human>()
                .Property(h => h.PhoneNumber)
                .HasMaxLength(13)
                .IsRequired();
            modelBuilder.Entity<Human>()
                .HasOne(c => c.Category)
                .WithMany()
                .HasForeignKey(h => h.CategoryId)
                .IsRequired();
            modelBuilder.Entity<Human>()
                .HasKey(h => h.TicketId);
            modelBuilder.Entity<Human>()
                .HasOne(h => h.Ticket)
                .WithMany()
                .HasForeignKey(h => h.TicketId);
            //Category
            modelBuilder.Entity<Category>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<Category>()
                .Property(c => c.Name)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<Category>()
                .HasData(
                    new { Id = 1, Name = "Davrli reyslar" },
                    new { Id = 2, Name = "Tarif reyslar" },
                    new { Id = 3, Name = "Xalqaro reyslar" },
                    new { Id = 4, Name = "Transiti reyslar" },
                    new { Id = 5, Name = "Chaqqon reyslar" }
                );
            //Ticket
            modelBuilder.Entity<Ticket>()
                .HasKey(t => t.Id);
            modelBuilder.Entity<Ticket>()
                .Property(t => t.Flight)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<Ticket>()
                .Property(t => t.Price)
                .IsRequired();
            modelBuilder.Entity<Ticket>()
                .Property(t => t.Date)
                .HasDefaultValue(DateTime.UtcNow);
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
