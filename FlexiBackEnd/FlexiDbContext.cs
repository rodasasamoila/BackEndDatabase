using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlexiBackEnd
{
    public class FlexiDbContext:DbContext
    {
        public FlexiDbContext(DbContextOptions<FlexiDbContext> options):base(options)
        {

        }
        public DbSet<Request> Requests { get; set; }
    }
}
