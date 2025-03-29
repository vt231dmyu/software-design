using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DeliveryLogger : IWarehouseOperationLogger
    {
        public void Log(IWarehouse warehouse, IProduct product)
        {
            warehouse.AddProduct(product);
            Console.WriteLine($"[Прибуткова накладна] Надходження товару: {product.Name}, Кількість: {product.Quantity}");
        }
    }
}
