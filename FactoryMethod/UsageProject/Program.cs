using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsageProject
{
    class Program
    {
        static void Main(string[] args)
        {
            SubscriptionFactory domesticFactory = new DomesticSubscriptionFactory();
            SubscriptionFactory educationalFactory = new EducationalSubscriptionFactory();
            SubscriptionFactory premiumFactory = new PremiumSubscriptionFactory();

            SubscriptionPurchaseChannel website = new WebSite(domesticFactory);
            SubscriptionPurchaseChannel mobileApp = new MobileApp(educationalFactory);
            SubscriptionPurchaseChannel managerCall = new ManagerCall(premiumFactory);

            Subscription domesticSubscription = website.PurchaseSubscription();
            Subscription educationalSubscription = mobileApp.PurchaseSubscription();
            Subscription premiumSubscription = managerCall.PurchaseSubscription();

            Console.WriteLine("\n=========================\n");

            Console.WriteLine(domesticSubscription);
            Console.WriteLine(educationalSubscription);
            Console.WriteLine(premiumSubscription);
        }
    }
}
