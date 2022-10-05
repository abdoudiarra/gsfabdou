using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using APIGSF.DTOs;
using APIGSF.Data;
using APIGSF.Entities;
using API.Controllers;

namespace APIGSF.Controllers
{
    public class AccountController : BaseApiController
    {
        //Un account peut login et register

        private readonly DataContext _context;
        public AccountController(DataContext context)
        {
            _context = context;

        }

        //Register
        [HttpPost("register")]
        public async Task<ActionResult<AppUserDto>> Register(RegisterDto registerDto)
        {

            
            var user = new AppUser
            {
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                Email = registerDto.Email,
                UserName = registerDto.UserName.ToLower(),
                Password = registerDto.Password,
                

                
            };

            _context.Users.Add(user);

            await _context.SaveChangesAsync();

            //object mapper

            return new AppUserDto
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Username = user.UserName,
                Password = user.Password
            };
        }

        private ActionResult<AppUserDto> BadRequest(string v)
        {
            throw new NotImplementedException(v);
        }

        private Task<bool> UserExists(string username)
        {
            throw new NotImplementedException(username);
        }

        //login
        [HttpPost("login")]

        public async Task<ActionResult<AppUserDto>> Login(LoginDto loginDto)
        {

            //get user in the database
            var user = await _context.Users.SingleOrDefaultAsync(x => x.UserName == loginDto.UserName && x.Password == loginDto.Password);

            if (user == null) return Unauthorized("Invalid username ");


            return new AppUserDto
            {
                Username = user.UserName,
                Password = user.Password
            };
        }

        private ActionResult<AppUserDto> Unauthorized(string v)
        {
            throw new NotImplementedException();
        }
    }
}

