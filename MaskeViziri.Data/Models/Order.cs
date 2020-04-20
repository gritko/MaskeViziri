using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeViziri.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ShippingAddress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int PhoneNumber { get; set; }
        public int AlternativePhoneNumber { get; set; }
        public ProtectionEquipment OrderItem { get; set; }
        public int OrderedQuantity { get; set; }
        public int Receipt { get; set; }
    }
}

// 001 | Bate Brkica 16 | Novi Sad | Serbia | 064 1615800 | - | 1 | 20 | 3399