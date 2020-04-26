using MaskeViziri.Data.Services;

namespace MaskeViziri.Data.Models
{
    public class OrderItem 
    {
        private readonly double Discount;
        private readonly double _price;

        public string Name { get; set; }
        public int Id { get; set; }
        public int Amount { get; set; }

        public double Price
        {
            get
            {
                return calculatePrice();
            }
            set { }
        }

        private double calculatePrice()
        {
            return _price * Discount;

        }
    }
}