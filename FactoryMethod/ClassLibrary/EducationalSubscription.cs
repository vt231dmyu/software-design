using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class EducationalSubscription : Subscription
    {
        public override double MonthlyFee => 5.99;
        public override int MinimumSubscriptionPeriodInMonths => 3;
        public override List<string> Channels => new List<string> { "Science Channel", "History Channel" };
        public override List<string> Features => new List<string> { "Educational Content", "Access to Courses" };
        public override string ToString()
        {
            return "Educational Subscription\n" +
                $"Monthly Fee: {MonthlyFee}\n" +
                $"Minimum Subscription Period: {MinimumSubscriptionPeriodInMonths} month(s)\n" +
                "Channels: " + string.Join(", ", Channels) + "\n" +
                "Features: " + string.Join(", ", Features) + "\n";
        }
    }
}
