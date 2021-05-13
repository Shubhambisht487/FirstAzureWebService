using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAzureWebService.Models;
namespace FirstAzureWebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //List<Employee> Employee=new List<Employee>();
        
            private EmployeeDbContext _context;
        public EmployeeController(EmployeeDbContext context)
        {

            _context = context;
            if (!_context.Employees.Any())
            {
                _context.Employees.Add(new Employee
                {Id=10,Name="Chris Gayle",Salary=100000,Department="Cricket" });
                _context.SaveChanges();
            }
        }
        [HttpGet]
        public IEnumerable<Employee> GetWorkshops()
        {
            return _context.Employees;
        }

    }
}
