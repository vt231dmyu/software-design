using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IProduct
    {
        string Name { get; }
        IMoney Price { get; }
        int Quantity { get; }
        IMoney ReducePrice(int whole, int fractional);
        int ReduceQuantity(int quantity);
        string ToString();
    }
}
