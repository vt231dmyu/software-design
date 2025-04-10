using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class SubscriptionPurchaseChannel
    {
        protected SubscriptionFactory _factory;

        public SubscriptionPurchaseChannel(SubscriptionFactory factory)
        {
            _factory = factory;
        }

        public abstract Subscription PurchaseSubscription();
    }
}
