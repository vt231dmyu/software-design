using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DomesticSubscriptionFactory : SubscriptionFactory
    {
        public override Subscription CreateSubscription()
        {
            Console.WriteLine("Creating Domestic Subscription...");
            return new DomesticSubscription();
        }
    }
}
