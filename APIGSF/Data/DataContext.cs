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

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}

