using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace inv.Models
{
    public class invContext : DbContext
    {
        public invContext (DbContextOptions<invContext> options)
            : base(options)
        {
        }

        public DbSet<inv.Models.product> product { get; set; }
    }
}
