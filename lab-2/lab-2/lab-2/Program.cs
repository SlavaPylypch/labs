using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create factories
            ISubscriptionFactory webSiteFactory = new WebSiteFactory();
            ISubscriptionFactory mobileAppFactory = new MobileAppFactory();
            ISubscriptionFactory managerCallFactory = new ManagerCallFactory();

            // Create subscriptions
            ISubscription webSubscription = webSiteFactory.CreateSubscription(false);
            ISubscription mobileSubscription = mobileAppFactory.CreateSubscription(true);
            ISubscription managerSubscription = managerCallFactory.CreateSubscription(false);

            // Show subscription details
            webSubscription.ShowDetails();
            Console.WriteLine();
            mobileSubscription.ShowDetails();
            Console.WriteLine();
            managerSubscription.ShowDetails();
            Console.ReadKey();
        }
    }
}
