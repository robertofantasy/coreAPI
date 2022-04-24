using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _Context;
        public UsersController(DataContext Context)
        {
            _Context = Context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUser()
        {
            return await _Context.Users.ToListAsync();
          
        }


        [HttpGet("{id}")]
        public async  Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await _Context.Users.FindAsync(id);
          
        }
    }
}