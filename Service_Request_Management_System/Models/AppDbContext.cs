using Microsoft.EntityFrameworkCore;

namespace Service_Request_Management_System.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Notice> Notices { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TicketHistory> TicketHistories { get; set; }
        public DbSet<TicketQueue> TicketQueues { get; set; }

    }
}
