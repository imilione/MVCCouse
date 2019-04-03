using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sales_2.Models
{
    public class Sales_2Context : DbContext
    {
        public Sales_2Context (DbContextOptions<Sales_2Context> options)
            : base(options)
        {
        }

        public DbSet<Sales_2.Models.Department> Department { get; set; }
    }
}
