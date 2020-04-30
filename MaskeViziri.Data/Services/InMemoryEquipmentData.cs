using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaskeViziri.Data.Models;

namespace MaskeViziri.Data.Services
{
    // ToDo
    // class for testing purposes
    public class InMemoryEquipmentData : IProductData
    {
        List<Product> productList;

        public InMemoryEquipmentData()
        {
            productList = new List<Product>()
            {
                new Product { Id = 1, Name = "Papirne maske", Price = 60.00 },
                new Product { Id = 2, Name = "Tekstilne maske", Price = 120.00},
                new Product { Id = 3, Name = "Viziri", Price = 500.00},
            };
        }

        public IEnumerable<Product> GetAll()
        {
            return productList.OrderBy(e => e.Id);
        }

        //public void AddCount(ProtectionEquipment equipment)
        //{
        //    var equipmentType = Get(equipment.Id);
        //    if (equipmentType != null)
        //    {
        //        equipmentType.OrderQuantity += 1;
        //    }
        //}
        public Product Get(int id)
        {
            return productList.FirstOrDefault(e => e.Id == id);
        }
    }
}
