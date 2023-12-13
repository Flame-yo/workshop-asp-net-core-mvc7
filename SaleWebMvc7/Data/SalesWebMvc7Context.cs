using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc7.Models;

namespace SalesWebMvc7.Data
{
    public class SalesWebMvc7Context : DbContext
    {
        public SalesWebMvc7Context (DbContextOptions<SalesWebMvc7Context> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
