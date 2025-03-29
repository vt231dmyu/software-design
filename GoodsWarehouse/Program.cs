using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
//---
using ClassLibrary;

namespace GoodsWarehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            //---

            IMoney applePrice = new UAHMoney(2, 50);
            IProduct apple = new Product("Яблуко", applePrice, 100);

            IMoney laptopPrice = new EuroMoney(505, 99);
            IProduct laptop = new Product("Ноутбук Acer", laptopPrice, 70);

            IWarehouse warehouse = new Warehouse("шт");

            IWarehouseOperationLogger deliveryLogger = new DeliveryLogger();
            IWarehouseOperationLogger shipmentLogger = new ShipmentLogger();
            IReporting reporting = new Reporting();

            Console.WriteLine(reporting.GenerateInventoryReport(warehouse));
            deliveryLogger.Log(warehouse, apple);
            Console.WriteLine(reporting.GenerateInventoryReport(warehouse));
            deliveryLogger.Log(warehouse, laptop);
            Console.WriteLine(reporting.GenerateInventoryReport(warehouse));

            IProduct appleShipment = new Product("Яблуко", applePrice, 80);
            shipmentLogger.Log(warehouse, appleShipment);
            Console.WriteLine(reporting.GenerateInventoryReport(warehouse));
            IProduct laptopShipment = new Product("Ноутбук Acer", laptopPrice, 30);
            shipmentLogger.Log(warehouse, laptopShipment);
            Console.WriteLine(reporting.GenerateInventoryReport(warehouse));
        }
    }
}
