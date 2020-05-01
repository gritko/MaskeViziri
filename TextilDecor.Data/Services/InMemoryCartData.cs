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

        Cart cart;
        //HashSet<OrderItem> cartList;
        HashSet<OrderItem> cartList = new HashSet<OrderItem>()
            {
                new OrderItem { Id = 22, ProductId = 1, Name = "Papirne maske", Price = 60.00, Amount = 200 },
                new OrderItem { Id = 23, ProductId = 2, Name = "Textilne maske", Price = 120.00, Amount = 100 },
                new OrderItem { Id = 24, ProductId = 3, Name = "Viziri", Price = 300.00, Amount = 30 },
            };
        public InMemoryCartData()
        {
            cart = new Cart(222, cartList);
        }
        

        //public void AddCount(ProtectionEquipment equipment)
        //{
        //    var equipmentType = Get(equipment.Id);
        //    if (equipmentType != null)
        //    {
        //        equipmentType.OrderQuantity += 1;
        //    }
        //}
        public Cart Get(int id)
        {
            return cart;
        }
    }
}