using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace BasicAspCore.Models
{

        public class EFDataContext : DbContext
        {
            public EFDataContext(DbContextOptions<EFDataContext> options)
                : base(options)
            {

            }

            public DbSet<Product> Products { get; set; }
            public DbSet<Category> Categories { get; set; }
        }
    
}
