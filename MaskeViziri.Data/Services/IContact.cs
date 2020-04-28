using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeViziri.Data.Services
{
    public interface IContact
    {
        string Name { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string Country { get; set; }
        int PhoneNumber { get; set; }
        int AlternativePhoneNumber { get; set; }
    }
}
