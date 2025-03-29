using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IWarehouseOperationLogger
    {
        void Log(IWarehouse warehouse, IProduct product);
    }
}
