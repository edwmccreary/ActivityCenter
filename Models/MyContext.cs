using Microsoft.EntityFrameworkCore;
namespace ActivityCenter.Models
{ 
    public class MyContext : DbContext
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        //Add your tables below:
        public DbSet<User> Users { get; set; }
        public DbSet<Meetup> Meetups { get; set; }
        public DbSet<RSVP> RSVPs { get; set; }
    }
}