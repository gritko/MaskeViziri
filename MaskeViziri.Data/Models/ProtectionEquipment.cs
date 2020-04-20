using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZastitneMaske.Data.Models
{
    public class ProtectionEquipment
    {
        public int Id { get; set; }
        public EquipmentType Equipment { get; set; }
        public int OrderCount { get; set; }

    }
}
