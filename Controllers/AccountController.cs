using Microsoft.EntityFrameworkCore;
using CourseApi.Data;
using CourseApi.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace CourseApi.Controllers
{
    [ApiController]
    [Route("AlexTestAPI/Accounts/Models")]

    public class AccountController : Controller {
        private DataContext _context;

        public AccountController(DataContext context){
            _context = context;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Account>>> GetAction([FromServices] DataContext context)
        {
            var accounts = await context.Accounts.Include(x => x.owner).ToListAsync();
            return accounts; 
        }

        [HttpPost]
        [Route("")]
        
        public async Task<ActionResult<Account>> Post([FromServices] DataContext context, [FromBody] Account model){
            if(!ModelState.IsValid) {return BadRequest(ModelState); }
            context.Accounts.Add(model);
            await context.SaveChangesAsync();
            return model;
        }

        [HttpDelete]
        [Route("")]

        public async Task<ActionResult<Account>> Delete([FromServices] DataContext context, [FromBody] Account model){
            context.Accounts.Remove(model);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        [Route("")]

        public async Task<ActionResult<Account>> Update([FromServices] DataContext context, [FromBody] Account model){
            context.Accounts.Update(model);
            await context.SaveChangesAsync();
            return model;
        }
    }

}