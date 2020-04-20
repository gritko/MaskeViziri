using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaskeViziri.Data.Models;

namespace MaskeViziri.Data.Services
{
    public class InMemoryEquipmentData : IEquipmentData
    {
        List<ProtectionEquipment> equipmentList;

        public InMemoryEquipmentData()
        {
            equipmentList = new List<ProtectionEquipment>()
            {
                new ProtectionEquipment { Id = 1, Equipment = EquipmentType.MaskeOdPapira, imgLoc = "face-mask.jpg" },
                new ProtectionEquipment { Id = 2, Equipment = EquipmentType.MaskeOdTekstila, imgLoc = "textilleMaskDesign.jpg" },
                new ProtectionEquipment { Id = 3, Equipment = EquipmentType.Viziri, imgLoc = "vizir.jpg" }
            };
        }

        public IEnumerable<ProtectionEquipment> GetAll()
        {
            return equipmentList.OrderBy(e => e.Id);
        }

        //public void AddCount(ProtectionEquipment equipment)
        //{
        //    var equipmentType = Get(equipment.Id);
        //    if (equipmentType != null)
        //    {
        //        equipmentType.OrderQuantity += 1;
        //    }
        //}
        public ProtectionEquipment Get(int id)
        {
            return equipmentList.FirstOrDefault(e => e.Id == id);
        }
    }
}
