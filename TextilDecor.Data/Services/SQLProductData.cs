using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextilDecor.Data.Models;

namespace TextilDecor.Data.Services
{
    public class SQLProductData : IProduct
    {
        private readonly ProductDbContext db;
        public SQLProductData(ProductDbContext db)
        {
            this.db = db;
        }

        public void Add(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public Product Get(int id)
        {
            return db.Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return from p in db.Products
                   orderby p.Id
                   select p;
        }

        public void Update(Product product)
        {
            var entry = db.Entry(product);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
