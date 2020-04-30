using System.Collections.Generic;
using MaskeViziri.Data.Models;

namespace MaskeViziri.Data.Services
{
    public interface IProductData
    {
        //Returns obj with: Id(int), Equipment(enum), OrderQuantity(int), imgLoc(string)
        IEnumerable<Product> GetAll();
        Product Get(int id);
    }
}