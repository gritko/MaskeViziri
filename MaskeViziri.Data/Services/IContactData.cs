using MaskeViziri.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeViziri.Data.Services
{
    interface IContactData
    {
        IEnumerable<Contact> GetAll();
        Contact GetContact(int Id);
    }
}
