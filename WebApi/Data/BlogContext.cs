using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext (DbContextOptions<BlogContext> options)
            : base(options)
        {
        }

        public DbSet<WebApi.Models.Blog> Blog { get; set; } = default!;
    }
}
