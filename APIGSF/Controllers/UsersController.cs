using System;
using API.Controllers;
using APIGSF.Data;
using APIGSF.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIGSF.Controllers
{
    public class UsersController : BaseApiController
    {
        //On peut demander d'avoir tout les users
        //On peut demander d'avoir un seul user selon son id
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = _context.Users.ToListAsync();

            return await users;
        }

        //api/users/2
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUsers(int id)
        {
            return await _context.Users.FindAsync(id);

        }
    }
}

