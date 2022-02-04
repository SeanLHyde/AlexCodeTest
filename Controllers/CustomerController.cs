using Microsoft.EntityFrameworkCore;
using CourseApi.Data;
using CourseApi.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace CourseApi.Controllers
{
    [ApiController]
    [Route("AlexTestAPI/Customers/Models")]

    public class CustomerController : Controller {
        private DataContext _context;

        public CustomerController(DataContext context){
            _context = context;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Customer>>> GetAction([FromServices] DataContext context)
        {
            var customer = await context.Customers.ToListAsync();
            return customer; 
        }

        [HttpPost]
        [Route("")]
        
        public async Task<ActionResult<Customer>> Post([FromServices] DataContext context, [FromBody] Customer model){
            if(!ModelState.IsValid) {return BadRequest(ModelState); }
            context.Customers.Add(model);
            await context.SaveChangesAsync();
            return model;
        }

        [HttpDelete]
        [Route("")]

        public async Task<ActionResult<Customer>> Delete([FromServices] DataContext context, [FromBody] Customer model){
            context.Customers.Remove(model);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        [Route("")]

        public async Task<ActionResult<Customer>> Update([FromServices] DataContext context, [FromBody] Customer model){
            context.Customers.Update(model);
            await context.SaveChangesAsync();
            return model;
        }
    }

}