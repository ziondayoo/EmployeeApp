using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace EmployeeApp.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<EmployeeModel> Employees { get; set; }


    }
}
