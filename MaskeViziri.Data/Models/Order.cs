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
        public Cart Cart { get; set; }
        public Contact Contact { get; set; }

    }
}

// 001 | Bate Brkica 16 | Novi Sad | Serbia | 064 1615800 | - | 1 | 100 | 3399
// Id  |                        Contact                   | OderIte | Cart 