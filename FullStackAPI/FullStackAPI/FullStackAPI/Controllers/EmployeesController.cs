using FullStackAPI.Data;
using FullStackAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FullStackAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _dbcontext;
        public EmployeesController(ApplicationDbContext dbContext) { 
        this._dbcontext=dbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllEmployee()
        {
            var employees = await _dbcontext.Employees.ToListAsync();
            return Ok(employees);
            }
        [HttpPost]
        public async Task<IActionResult> AddEmployees(Employee employee)
        {
            await _dbcontext.Employees.AddAsync(employee);
            await _dbcontext.SaveChangesAsync();
            return Ok(employee);
        }
    }
}
