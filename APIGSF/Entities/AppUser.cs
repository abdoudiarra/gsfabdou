using System;
using Microsoft.Extensions.Hosting;

namespace APIGSF.Entities
{
    public class AppUser
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<AppUser> Followers { get; set; }
        public List<AppUser> Following { get; set; }
        public List<Post> Posts { get; set; }
        public List<Post> Saved { get; set; }
        public List<Notification> Notifications { get; set; }

    }
}

