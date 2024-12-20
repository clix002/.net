using Microsoft.EntityFrameworkCore;
using Web_Api_01.Models.Entities;

namespace Web_Api_01.data;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Employee> Employees { get; set; }
}