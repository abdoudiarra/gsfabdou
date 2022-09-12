using System;
namespace APIGSF.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public Boolean Liked { get; set; }
        public Boolean Saved { get; set; }
        public List<Comments> Comments { get; set; }
    }
}

