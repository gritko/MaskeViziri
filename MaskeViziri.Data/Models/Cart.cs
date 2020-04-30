using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeViziri.Data.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public HashSet<OrderItem> OrderItems { get; set; }
        
        public double Price
        { 
            get 
            { 
                return Price; 
            }
            private set
            {
                Price = value;
            }
        }

        private void Add(OrderItem item)
        {
            OrderItems.Add(item);
            Price += item.Price;
        }
        
        private void Remove(OrderItem item)
        {
            OrderItems.Remove(item);
            Price -= item.Price;
        }
        
        private void RemoveAll(OrderItem item)
        {
            OrderItems.Clear();
            OrderItems.TrimExcess();
            Price = default;
        }
        private void RemoveAll(HashSet<OrderItem> OrderItems)
        {
            foreach (OrderItem item in OrderItems)
            {
                Remove(item);
            }
        }



        // methods for placing an order        
        // 41 | (Papirne maske, Viziri, Hirurske maske) | 1499

    }
}
