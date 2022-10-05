using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIGSF.Entities
{
    [Table("Posts")]
    public class Posts
    {
        public virtual int Id { get; set; }
        public virtual string Caption { get; set; }
        public virtual bool Liked { get; set; }
        public virtual bool Saved { get; set; }
        public virtual List<Comments> Comments { get; set; }
        public virtual ICollection<AppUser> AppUser { get; set; }
    }
}

