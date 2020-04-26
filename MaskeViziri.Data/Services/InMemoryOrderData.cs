using MaskeViziri.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeViziri.Data.Services
{
    internal class InMemoryOrderData : IOrderdata, IContactData
    {
        List<Order> ordersList;

        public InMemoryOrderData()
        {
            new Order { Id = 20, ShippingAddress = "Puskinova", City = "Novi Sad", Country = "Srbija", PhoneNumber = 0123456789, AlternativePhoneNumber = 0, new OrderItem { Id = 30, new Contact { City = "Novi Sad" }, pro }, };
        }

        public IEnumerable<Contact> GetAll()
        {
            return ordersList.OrderBy(c => c.Id)
        }

        public Contact GetContact(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
