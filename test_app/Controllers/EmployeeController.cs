Project Name: RESTful API for Employee Management 

User Stories:

1. As an admin, I should be able to add new employees.
2. As an admin, I should be able to view all existing employees.
3. As an admin, I should be able to update existing employee information.
4. As an admin, I should be able to delete existing employees.

Using the .NET Core MVC framework, the following code creates a RESTful API for Employee Management:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace test_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        // GET api/employee
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            // Retrieve all employees from the database.
            var employees = await _context.Employees.ToListAsync();

            return employees;
        }

        // POST api/employee
        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
        {
            // Add the new employee to the database.
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployee", new { id = employee.Id }, employee);
        }

        // PUT api/employee/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult<Employee>> PutEmployee(int id, Employee employee)
        {
            // Update the existing employee in the database.
            _context.Entry(employee).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/employee/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult<Employee>> DeleteEmployee(int id)
        {
            // Retrieve the existing employee from the database.
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            // Delete the employee from the database.
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();

            return employee;
        }
    }
}