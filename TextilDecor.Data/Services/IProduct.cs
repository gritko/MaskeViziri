using TextilDecor.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextilDecor.Data.Services
{
    public interface IProduct
    {
        //ToDo
        //Just for the testing purposes
        IEnumerable<Product> GetAll();
        Product Get(int id);
        void Add(Product product);
        void Update(Product product);
    }
}
