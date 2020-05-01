using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextilDecor.Data.Models;

namespace TextilDecor.Data.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public string Description { get; set; }
        
        [Required]
        public double Price { get; set; }

        //private double _price;

        //public double Price
        //{
        //    get => _price;
        //    //TODO Logika za postavljanje vrednosti
        //    set { _price = value; }
        //}

    }
}
