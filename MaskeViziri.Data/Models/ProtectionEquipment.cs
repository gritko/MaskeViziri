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
        public int OrderQuantity { get; set; }
        public string imgLoc { get; set; }

    }
}
