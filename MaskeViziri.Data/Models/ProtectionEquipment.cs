using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaskeViziri.Data.Models;

namespace MaskeViziri.Data.Models
{
    public class ProtectionEquipment
    {
        public int Id { get; set; }
        public EquipmentType Equipment { get; set; }

        private double _price;

        public double Price
        {
            get { return _price; }
            //TODO Logika za postavljanje vrednosti
            set { _price = value; }
        }


        //TODO Ovo ne treba ovde, prebaciti u helper ili zaobici ovaj pristup
        public string imgLoc { get; set; }

    }
}
