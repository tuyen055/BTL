using Microsoft.EntityFrameworkCore;
using WebMVC.Models;

namespace WebMVC.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {}
        public DbSet<Person> Person { get; set;}
        public DbSet<Employee> Employee { get; set;}

        public DbSet<HeThongPhanPhoi> HeThongPhanPhoi { get; set; }

        public DbSet<DaiLy> DaiLy { get; set; } 
    }
}