using Microsoft.EntityFrameworkCore;
namespace AlertsProject.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<ErrorAlerts> ErrorAlerts { get; set; }
    }
}
