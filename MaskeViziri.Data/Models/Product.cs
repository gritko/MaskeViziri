using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaskeViziri.Data.Models;

namespace MaskeViziri.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        private double _price;

        public double Price
        {
            get => _price;
            //TODO Logika za postavljanje vrednosti
            set { _price = value; }
        }
    }
}
