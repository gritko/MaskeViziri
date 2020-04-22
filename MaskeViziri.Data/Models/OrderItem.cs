using MaskeViziri.Data.Services;

namespace MaskeViziri.Data.Models
{
    public class OrderItem
    {
        public ProtectionEquipment Id { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
    }
}