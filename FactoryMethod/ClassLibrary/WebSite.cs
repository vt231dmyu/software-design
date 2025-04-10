using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class WebSite : SubscriptionPurchaseChannel
    {
        public WebSite(SubscriptionFactory factory) : base(factory) { }

        public override Subscription PurchaseSubscription()
        {
            Console.WriteLine("Processing purchase through Website...");
            return _factory.CreateSubscription();
        }
    }
}
