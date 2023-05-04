using Microsoft.EntityFrameworkCore;

namespace LibraryCW.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {}
        public DbSet<Book> Books { get; set; }
        public DbSet<CatalogCard> CatalogCards { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Librarian> Librarians { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Edition> Editions { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
