using Microsoft.AspNetCore.Mvc;
using Web_Api_01.data;
using Web_Api_01.Models.Entities;
using Web_Api_01.Models.Entities.DTO;

namespace Web_Api_01.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerEmployee: ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ControllerEmployee(ApplicationDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult ListEmployees()
        {
            var employees = _context.Employees.ToList();
            return Ok(employees);
        }

        [HttpPost]
        public IActionResult AddEmployee(EmployeeDTO employee)
        {
            var employeEntitY = new Employee()
            {
                Nombre = employee.Nombre,
                Correo = employee.Correo,
                Telefono = employee.Telefono,
                Salario = employee.Salario,
            };

            if (employeEntitY is null)
            {
                return NotFound();
            }
            _context.Employees.Add(employeEntitY);
            _context.SaveChanges();
            
            return Ok(employee);
        }
    }
}