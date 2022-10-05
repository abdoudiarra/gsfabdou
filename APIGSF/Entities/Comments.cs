using System;
namespace APIGSF.Entities
{
    public class Comments
    {

        public int Id { get; set; }
        public string CommentString { get; set; }
        public virtual int PostsId {get; set;}
    }
}

