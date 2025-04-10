using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class PremiumSubscriptionFactory : SubscriptionFactory
    {
        public override Subscription CreateSubscription()
        {
            Console.WriteLine("Creating Premium Subscription...");
            return new PremiumSubscription();
        }
    }
}
