using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IMoney
    {
        int WholePart { get; }
        int FractionalPart { get; }
        void SetParts(int whole, int fractional);
        string GetCurrencySymbol();
        string ToString();
    }
}
