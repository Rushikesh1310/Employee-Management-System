using Employee_CRUD_Operation.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_CRUD_Operation.Data
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext>options) :base(options) { }
        public DbSet<Employee> Employees { get; set; }  
    }
}
