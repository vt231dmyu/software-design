## 1. DRY (Don’t Repeat Yourself)
### Inheritance:
- [`BaseMoney`](./ClassLibrary/BaseMoney.cs) contains common logic for currencies ([`EuroMoney`](./ClassLibrary/EuroMoney.cs), [`UAHMoney`](./ClassLibrary/UAHMoney.cs)), preventing code duplication when working with money.
### Interfaces:
- Using [`IProduct`](./ClassLibrary/IProduct.cs), [`IWarehouse`](./ClassLibrary/IWarehouse.cs), [`IMoney`](./ClassLibrary/IMoney.cs), [`IReporting`](./ClassLibrary/IReporting.cs) allows splitting responsibilities between classes and avoids method duplication.
### Methods:
- The method [`GenerateInventoryReport()`](./ClassLibrary/Reporting.cs#L11-L14) in [`Reporting`](./ClassLibrary/Reporting.cs) centralizes report generation, instead of having each class implement this logic individually.

## 2. KISS (Keep It Simple, Stupid)
### Clarity:
- Classes have clear responsibilities ([`Product`](./ClassLibrary/Product.cs) for products, [`Warehouse`](./ClassLibrary/Warehouse.cs) for inventory, [`DeliveryLogger`](./ClassLibrary/DeliveryLogger.cs) for logging deliveries, etc.).
### Minimal Complexity:
- Logging ([`DeliveryLogger`](./ClassLibrary/DeliveryLogger.cs), [`ShipmentLogger`](./ClassLibrary/ShipmentLogger.cs)) is separated from [`Warehouse`](./ClassLibrary/Warehouse.cs), making the code simpler.
### Additional Simplifications:
- Instead of creating a separate method for printing object fields, the `ToString()` method is overridden in [`BaseMoney`](./ClassLibrary/BaseMoney.cs#L23-L26) and [`Product`](./ClassLibrary/Product.cs#L31-L34) classes.

## 3. S - Single Responsibility Principle (SOLID)
### Each class has one responsibility:
- [`Product`](./ClassLibrary/Product.cs) — product description.
- [`Warehouse`](./ClassLibrary/Warehouse.cs) — warehouse management.
- [`BaseMoney`](./ClassLibrary/BaseMoney.cs) and its descendants — representing monetary units.
- [`DeliveryLogger`](./ClassLibrary/DeliveryLogger.cs) and [`ShipmentLogger`](./ClassLibrary/ShipmentLogger.cs) — event logging.
- [`Reporting`](./ClassLibrary/Reporting.cs) — report generation.

## 4. O - Open/Closed Principle (SOLID)
### Extensibility without modifying existing code:
- Currency handling logic can be extended by adding new classes (`USDMoney`, `CryptoMoney`) without changing [`BaseMoney`](./ClassLibrary/BaseMoney.cs).
- New logging types can be added by implementing [`IWarehouseOperationLogger`](./ClassLibrary/IWarehouseOperationLogger.cs) without modifying [`Warehouse`](./ClassLibrary/Warehouse.cs).

## 5. L - Liskov Substitution Principle (SOLID)
### The base class can be replaced by its subclass without changing behavior:
- [`EuroMoney`](./ClassLibrary/EuroMoney.cs) and [`UAHMoney`](./ClassLibrary/UAHMoney.cs) are subclasses of [`BaseMoney`](./ClassLibrary/BaseMoney.cs), and any [`IMoney`](./ClassLibrary/IMoney.cs) object can be used without changing the logic. If [`BaseMoney`](./ClassLibrary/BaseMoney.cs) is removed, the code will still work, but common methods ([`SetParts()`](./ClassLibrary/BaseMoney.cs#L17-L21), [`ToString()`](./ClassLibrary/BaseMoney.cs#L23-L26)) would need to be duplicated in each class.

## 6. I - Interface Segregation Principle (SOLID)
### Interfaces are clearly divided and do not contain unnecessary methods:
- [`IMoney`](./ClassLibrary/IMoney.cs), [`IProduct`](./ClassLibrary/IProduct.cs), [`IWarehouse`](./ClassLibrary/IWarehouse.cs), [`IReporting`](./ClassLibrary/IReporting.cs), [`IWarehouseOperationLogger`](./ClassLibrary/IWarehouseOperationLogger.cs) define only the methods they actually need.
- [`IProduct`](./ClassLibrary/IProduct.cs) does not have methods related to the warehouse, and [`IWarehouse`](./ClassLibrary/IWarehouse.cs) does not deal with product prices.

## 7. D - Dependency Inversion Principle (SOLID)
### Dependencies are used through interfaces:
- [`IMoney`](./ClassLibrary/IMoney.cs), [`IProduct`](./ClassLibrary/IProduct.cs), [`IWarehouse`](./ClassLibrary/IWarehouse.cs), [`IReporting`](./ClassLibrary/IReporting.cs), [`IWarehouseOperationLogger`](./ClassLibrary/IWarehouseOperationLogger.cs) are used as dependencies, allowing easy replacement of implementations without changing the core code ([`Warehouse`](./ClassLibrary/Warehouse.cs#L11), [`Product`](./ClassLibrary/Product.cs#L12), etc.).
- In [`Program`](./GoodsWarehouse/Program.cs#L28-L30), the objects [`DeliveryLogger`](./ClassLibrary/DeliveryLogger.cs), [`ShipmentLogger`](./ClassLibrary/ShipmentLogger.cs), and [`Reporting`](./ClassLibrary/Reporting.cs) work through interfaces.
