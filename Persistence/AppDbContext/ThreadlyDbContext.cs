using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.AppDbContext
{
    public class ThreadlyDbContext : DbContext
    {
        public ThreadlyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Community> Communities { get; set; }
        public DbSet<Post> Posts { get; set; }


    }
}
