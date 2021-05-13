using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAzureWebService.Models
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> context) : base(context)
        { 
        
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
