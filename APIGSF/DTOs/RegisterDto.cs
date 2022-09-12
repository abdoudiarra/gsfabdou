using System;
using System.ComponentModel.DataAnnotations;

namespace APIGSF.DTOs
{
    public class RegisterDto
    {
        
        [Required]
        public string FirsName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        
    }
}

