using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CrefisaPuma.Models
{
    public class CrefisaPumaContext : DbContext
    {
        public CrefisaPumaContext (DbContextOptions<CrefisaPumaContext> options)
            : base(options)
        {
        }

        public DbSet<CrefisaPuma.Models.Department> Department { get; set; }
    }
}
