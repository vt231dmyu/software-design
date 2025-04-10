using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ManagerCall : SubscriptionPurchaseChannel
    {
        public ManagerCall(SubscriptionFactory factory) : base(factory) { }

        public override Subscription PurchaseSubscription()
        {
            Console.WriteLine("Processing purchase through Manager Call...");
            return _factory.CreateSubscription();
        }
    }
}
