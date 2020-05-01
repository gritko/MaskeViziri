using TextilDecor.Data.Services;
//Mozda bi trebalo da budu u istom namespace-u zbog compile
namespace TextilDecor.Data.Models
{
    public class OrderItem 
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double ItemPrice { get; set; }
        private double Discount { get; set; }

        // razmisliti jos jednom da li ovo da ostane ovde ili da bude u Cart class 
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
            Price = (Price - (Price * Discount)) * Amount;
            return Price;

        }

        //public OrderItem(Product product, int amount, double discount = 1)
        //{
        //    ProductId = product.Id;
        //    Name = product.Name;
        //    ItemPrice = product.Price;
        //    Amount = amount;
        //    Discount = discount;
        //}

        //public OrderItem(int id, int ProductId, string name, double price, int amount, double discount = 1)
        //{
        //    Id = id;
        //    ProductId = ProductId;
        //    Name = name;
        //    ItemPrice = price;
        //    Amount = amount;
        //    Discount = discount;
        //}
        public OrderItem()
        {

        }
    }
}
//  001 | PapirnaMaska | 2000 | 0.2 | 80 RSD