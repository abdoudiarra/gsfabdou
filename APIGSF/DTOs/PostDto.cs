using System;
using APIGSF.Entities;

namespace APIGSF.DTOs
{
    public class PostDto
    {

        public int AppUserId { get; set; }
        public string Caption { get; set; }
        public bool Liked { get; set; }
        public bool Saved { get; set; }
        public List<Comments> Comments { get; set; }
        
    }
}

