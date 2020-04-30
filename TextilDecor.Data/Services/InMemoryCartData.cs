using TextilDecor.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextilDecor.Data.Services
{
    public class InMemoryCartData
    {
        IProduct db;
        public InMemoryCartData(IProduct db)
        {
            this.db = db;
        }

        List<OrderItem> cartList;
        
        IProduct product = db.Get(1);
        public InMemoryCartData()
        {
            cartList = new List<OrderItem>()
            {
                //public OrderItem(IProduct product, int amount, double discount = 1)
                new OrderItem { product = new Product { Id = 1, Name = "Papirne maske", Price = 60.00 }, Amount = 1200 },
                new OrderItem { Amount = 55 },
                new OrderItem { Amount = 3 } 
            };
        }

        public IEnumerable<Product> GetAll()
        {
            return cartList.OrderBy(e => e.Id);
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
            return cartList.FirstOrDefault(e => e.Id == id);
        }
    }
}
}
