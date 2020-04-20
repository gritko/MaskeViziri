using System.Collections.Generic;
using MaskeViziri.Data.Models;

namespace MaskeViziri.Data.Services
{
    public interface IEquipmentData
    {
        IEnumerable<ProtectionEquipment> GetAll();
        ProtectionEquipment Get(int id);
    }
}