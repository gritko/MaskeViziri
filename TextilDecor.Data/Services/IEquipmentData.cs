using System.Collections.Generic;
using TextilDecor.Data.Models;

namespace TextilDecor.Data.Services
{
    public interface IProductData
    {
        //Returns obj with: Id(int), Equipment(enum), OrderQuantity(int), imgLoc(string)
        IEnumerable<Product> GetAll();
        Product Get(int id);
    }
}