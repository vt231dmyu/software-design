using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Subscription
    {
        public abstract double MonthlyFee { get; }
        public abstract int MinimumSubscriptionPeriodInMonths { get; }
        public abstract List<string> Channels { get; }
        public abstract List<string> Features { get; }
    }
}
