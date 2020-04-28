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
        List<Product> equipmentList;

        public InMemoryEquipmentData()
        {
            equipmentList = new List<Product>()
            {
                new Product { Id = 1, Equipment = EquipmentType.MaskeOdPapira, imgLoc = "face-mask.jpg" },
                new Product { Id = 2, Equipment = EquipmentType.MaskeOdTekstila, imgLoc = "textilleMaskDesign.jpg" },
                new Product { Id = 3, Equipment = EquipmentType.Viziri, imgLoc = "vizir.jpg" }
            };
        }

        public IEnumerable<Product> GetAll()
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
        public Product Get(int id)
        {
            return equipmentList.FirstOrDefault(e => e.Id == id);
        }
    }
}
