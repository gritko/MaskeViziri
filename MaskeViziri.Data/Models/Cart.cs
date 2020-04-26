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


        //TODO Add remove and removeAll methods
        // 41 | (Papirne maske, Viziri, Hirurske maske) | 1499

    }
}
