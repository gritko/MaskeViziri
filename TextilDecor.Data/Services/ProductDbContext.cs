using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextilDecor.Data.Models;

namespace TextilDecor.Data.Services
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
