using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class EuroMoney : BaseMoney
    {
        public EuroMoney(int whole, int fractional) : base(whole, fractional) { }
        public override string GetCurrencySymbol() => "EUR";
    }
}
