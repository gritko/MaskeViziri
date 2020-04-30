using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextilDecor.Data.Services
{
    public interface ICart
    {
        int Id { get; }
        double Price { get; }
    }
}
