using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DomesticSubscription : Subscription
    {
        public override double MonthlyFee => 9.99;
        public override int MinimumSubscriptionPeriodInMonths => 1;
        public override List<string> Channels => new List<string> { "News Channel", "Weather Forecast Channel", "Shows Channel" };
        public override List<string> Features => new List<string> { "HD Quality", "Ad Free" };
        public override string ToString()
        {
            return "Domestic Subscription\n" +
                $"Monthly Fee: {MonthlyFee}\n" +
                $"Minimum Subscription Period: {MinimumSubscriptionPeriodInMonths} month(s)\n" +
                "Channels: " + string.Join(", ", Channels) + "\n" +
                "Features: " + string.Join(", ", Features) + "\n";
        }
    }
}
