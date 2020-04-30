using MaskeViziri.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeViziri.Data.Services
{
    public interface IProduct
    {
        string Name { get; set; }
        double Price { get; set; }

        //ToDo
        //Just for the testing purposes
        IEnumerable<Product> GetAll();
        Product Get(int id);
    }
}
