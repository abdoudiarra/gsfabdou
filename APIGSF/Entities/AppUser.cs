using System;
using System.ComponentModel.DataAnnotations;
using APIGSF.Extensions;
using Microsoft.Extensions.Hosting;


namespace APIGSF.Entities
{
    public class AppUser
    {

        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public ICollection<Photo>? Photos { get; set; }
        public List<AppUser>? Followers { get; set; }
        public List<AppUser>? Following { get; set; }
        public List<Post>? Posts { get; set; }
        public List<Post>? Saved { get; set; }
        public List<Notification>? Notifications { get; set; }

      
    }
}

