using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperExample.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DapperExample.Infrastructure.DatabaseContext
{
    public class DapperexampleDbContext : DbContext
    {
      public DapperexampleDbContext(DbContextOptions<DapperexampleDbContext> options)
    : base(options)
        {

        }
        public DbSet<Product> products { get; set; }
    }
}
