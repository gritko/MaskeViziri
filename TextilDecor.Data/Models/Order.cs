using TextilDecor.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextilDecor.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int PhoneNumber { get; set; }
        public int AlternativePhoneNumber { get; set; }

        public Order(ICart cart, IContact contact)
        {
            CartId                 = cart.Id;
            Price                  = cart.Price;
            Name                   = contact.Name;
            Address                = contact.Address;
            City                   = contact.City;
            Country                = contact.Country;
            PhoneNumber            = contact.PhoneNumber;
            AlternativePhoneNumber = contact.AlternativePhoneNumber;
        }

    }
}

// Order 001 | Bate Brkica 16 | Novi Sad | Serbia | 064 1615800 | id 1 | 0.2(popust) | 100 pcs| 3399 rsd |
// Id        |                        Contact                   |                     Cart               |

// Order 001 | Bate Brkica 16 | Novi Sad | Serbia | 064 1615800 | Papirne maske | 20 % | 100 pcs| 3399 rsd |
// Id        |                      Contact                     |                     Cart                 |