using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class EducationalSubscriptionFactory : SubscriptionFactory
    {
        public override Subscription CreateSubscription()
        {
            Console.WriteLine("Creating Educational Subscription...");
            return new EducationalSubscription();
        }
    }
}
