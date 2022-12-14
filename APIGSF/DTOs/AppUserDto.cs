using System;
using System.ComponentModel.DataAnnotations.Schema;
using APIGSF.Entities;

namespace APIGSF.DTOs
{
    public class AppUserDto
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<AppUser> Followers { get; set; }
        public List<AppUser> Following { get; set; }
        public List<Posts> Posts { get; set; }
        public List<Notification> Notifications { get; set; }
    }
}

