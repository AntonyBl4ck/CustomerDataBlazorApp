using Microsoft.AspNetCore.Mvc;
using CustomerDataApi.Data;
using CustomerDataApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CustomerDataApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("users")]
        public async Task<IActionResult> GetCustomers()
        {
            var customers = await _context.Customers.ToListAsync();
            return Ok(customers);
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterCustomer(Customer customer)
        {
            if (await _context.Customers.AnyAsync(c => c.Email == customer.Email))
            {
                return Conflict("A user with this email is already registered.");
            }

            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return Ok(customer);
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginCustomer([FromBody] LoginModel login)
        {
            if (login == null || string.IsNullOrWhiteSpace(login.Email))
            {
                return BadRequest("Email cannot be empty.");
            }

            var existingCustomer = await _context.Customers
                .SingleOrDefaultAsync(c => c.Email.ToLower() == login.Email.ToLower());

            if (existingCustomer == null)
            {
                return NotFound(new { Message = "User with this email not found." });
            }

            HttpContext.Session.SetString("UserEmail", existingCustomer.Email);
            HttpContext.Session.SetString("UserFirstName", existingCustomer.FirstName);

            return Ok(new
            {
                FirstName = existingCustomer.FirstName,
                Email = existingCustomer.Email
            });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
