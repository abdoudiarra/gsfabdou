using System;
using APIGSF.Entities;
using Microsoft.EntityFrameworkCore;

namespace APIGSF.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<AppUser> Users { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
    }
}

