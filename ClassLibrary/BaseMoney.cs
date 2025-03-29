using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class BaseMoney : IMoney
    {
        public int WholePart { get; private set; }
        public int FractionalPart { get; private set; }
        protected BaseMoney(int whole, int fractional)
        {
            SetParts(whole, fractional);
        }
        public void SetParts(int whole, int fractional)
        {
            WholePart = whole;
            FractionalPart  = fractional;
        }
        public abstract string GetCurrencySymbol();
        public override string ToString()
        {
            return $"{WholePart}.{FractionalPart:D2} {GetCurrencySymbol()}";
        }
    }
}
