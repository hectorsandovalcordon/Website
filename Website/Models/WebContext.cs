using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Models
{
    public class WebContext: DbContext
    {
        public WebContext(DbContextOptions<WebContext> options)
         : base(options)
        { }

        public DbSet<Proyecto> Proyectos { get; set; }
    }
}
