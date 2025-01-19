using Microsoft.EntityFrameworkCore;
using hotel_app.Models;

namespace hotel_app.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(e => e.Role)
                .HasConversion<string>();
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Sejour> Sejours { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<LigneService> LigneServices { get; set; }
        public DbSet<Facture> Factures { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Client> Clients{ get; set; }
        public DbSet<TypeChambre> TypeChambres { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}
