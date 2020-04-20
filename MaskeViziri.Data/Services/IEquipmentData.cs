using System.Collections.Generic;
using ZastitneMaske.Data.Models;

namespace ZastitneMaske.Data.Services
{
    public interface IEquipmentData
    {
        IEnumerable<ProtectionEquipment> GetAll();
        ProtectionEquipment Get(int id);
    }
}