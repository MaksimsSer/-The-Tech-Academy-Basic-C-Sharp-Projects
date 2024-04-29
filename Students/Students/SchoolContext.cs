using Microsoft.EntityFrameworkCore;

namespace EFCodeFirstDemo
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=laptop-0fm44klm\\sqlexpress;Database=Students;Trusted_Connection=True;");
        }
    }
}