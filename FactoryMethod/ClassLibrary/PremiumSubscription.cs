using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class PremiumSubscription : Subscription
    {
        public override double MonthlyFee => 19.99;
        public override int MinimumSubscriptionPeriodInMonths => 1;
        public override List<string> Channels => new List<string> { "All Channels" };
        public override List<string> Features => new List<string> { "4K Quality", "Ad Free", "Exclusive Content" };
        public override string ToString()
        {
            return "Premium Subscription\n" +
                $"Monthly Fee: {MonthlyFee}\n" +
                $"Minimum Subscription Period: {MinimumSubscriptionPeriodInMonths} month(s)\n" +
                "Channels: " + string.Join(", ", Channels) + "\n" +
                "Features: " + string.Join(", ", Features) + "\n";
        }
    }
}
