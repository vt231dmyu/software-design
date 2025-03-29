## 1. DRY (Don’t Repeat Yourself)
### Inheritance:
- `BaseMoney` contains common logic for currencies (`EuroMoney`, `UAHMoney`), preventing code duplication when working with money.
### Interfaces:
- Using `IProduct`, `IWarehouse`, `IMoney`, `IReporting` allows splitting responsibilities between classes and avoids method duplication.
### Methods:
- The method `GenerateInventoryReport()` in `Reporting` centralizes report generation, instead of having each class implement this logic individually.

## 2. KISS (Keep It Simple, Stupid)
### Clarity:
- Classes have clear responsibilities (`Product` for products, `Warehouse` for inventory, `DeliveryLogger` for logging deliveries, etc.).
### Minimal Complexity:
- Logging (`DeliveryLogger`, `ShipmentLogger`) is separated from `Warehouse`, making the code simpler.
### Additional Simplifications:
- Instead of creating a separate method for printing object fields, the `ToString()` method is overridden in `BaseMoney` and `Product` classes.

## 3. S - Single Responsibility Principle (SOLID)
### Each class has one responsibility:
- `Product` — product description.
- `Warehouse` — warehouse management.
- `BaseMoney` and its descendants — representing monetary units.
- `DeliveryLogger` and `ShipmentLogger` — event logging.
- `Reporting` — report generation.

## 4. O - Open/Closed Principle (SOLID)
### Extensibility without modifying existing code:
- Currency handling logic can be extended by adding new classes (`USDMoney`, `CryptoMoney`) without changing `BaseMoney`.
- New logging types can be added by implementing `IWarehouseOperationLogger` without modifying `Warehouse`.

## 5. L - Liskov Substitution Principle (SOLID)
### The base class can be replaced by its subclass without changing behavior:
- `EuroMoney` and `UAHMoney` are subclasses of `BaseMoney`, and any `IMoney` object can be used without changing the logic. If `BaseMoney` is removed, the code will still work, but common methods (`SetParts()`, `ToString()`) would need to be duplicated in each class.

## 6. I - Interface Segregation Principle (SOLID)
### Interfaces are clearly divided and do not contain unnecessary methods:
- `IMoney`, `IProduct`, `IWarehouse`, `IReporting`, `IWarehouseOperationLogger` define only the methods they actually need.
- `IProduct` does not have methods related to the warehouse, and `IWarehouse` does not deal with product prices.

## 7. D - Dependency Inversion Principle (SOLID)
### Dependencies are used through interfaces:
- `IMoney`, `IProduct`, `IWarehouse`, `IReporting`, `IWarehouseOperationLogger` are used as dependencies, allowing easy replacement of implementations without changing the core code (`Warehouse`, `Product`, etc.).
- In `Program`, the objects `DeliveryLogger`, `ShipmentLogger`, and `Reporting` work through interfaces.