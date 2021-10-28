using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlogDominio.Entidades;

namespace BlogApi.Data
{
    public class BlogApiContext : DbContext
    {
        public BlogApiContext (DbContextOptions<BlogApiContext> options)
            : base(options)
        {
        }

        public DbSet<BlogDominio.Entidades.Blog> Blog { get; set; }
    }
}
