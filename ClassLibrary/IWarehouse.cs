using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IWarehouse
    {
        List<IProduct> Products { get; }
        string Unit { get; }
        DateTime LastDeliveryDate { get; }
        void AddProduct(IProduct product);
        bool RemoveProduct(string productName, int quantity);
        string ShowProducts();
    }
}
