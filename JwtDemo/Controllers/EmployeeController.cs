using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtDemo.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        private static readonly List<Employee> Employees = new List<Employee>
        {
            new Employee { EmpId = 1, FirstName = "Aman", LastName = "Kumar", DateOfBirth = DateTime.Parse("1985-10-15"), Department = "IT" },
            new Employee { EmpId = 2, FirstName = "Abhishek", LastName = "Kumar", DateOfBirth = DateTime.Parse("1990-07-21"), Department = "HR" },
        };

        [HttpGet]
        public IEnumerable<Employee> Get()
          {
            _logger.LogInformation("This method has executed now...");
            return Employees;
        }

    }
}
