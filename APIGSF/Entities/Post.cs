﻿using System;
namespace APIGSF.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public bool Liked { get; set; }
        public bool Saved { get; set; }
        public List<Comments> Comments { get; set; }
    }
}

