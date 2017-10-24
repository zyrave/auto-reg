using auto_reg.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace auto_reg.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<EmployeeAttendance> EmployeeAttendances { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
