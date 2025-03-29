using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ShipmentLogger: IWarehouseOperationLogger
    {
        public void Log(IWarehouse warehouse, IProduct product)
        {
            string productName = product.Name;
            int quantity = product.Quantity;
            if (warehouse.RemoveProduct(productName, quantity))
            {
                Console.WriteLine($"[Видаткова накладна] Відвантажено: {productName}, Кількість: {quantity}");
            }
            else
            {
                Console.WriteLine($"Помилка: Недостатня кількість {productName} на складі або товар не знайдено.");
            }
        }
    }
}
