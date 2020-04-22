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
        public List<OrderItem> Items { get; set; }
        public int Price { get; set; }
    }
}
