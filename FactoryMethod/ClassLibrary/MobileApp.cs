using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MobileApp : SubscriptionPurchaseChannel
    {
        public MobileApp(SubscriptionFactory factory) : base(factory) { }

        public override Subscription PurchaseSubscription()
        {
            Console.WriteLine("Processing purchase through Mobile App...");
            return _factory.CreateSubscription();
        }
    }
}
