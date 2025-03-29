using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Reporting : IReporting
    {
        public string GenerateInventoryReport(IWarehouse warehouse)
        {
            return $"[Інвентаризаційний звіт]\n{warehouse.ShowProducts()}";
        }
    }
}
