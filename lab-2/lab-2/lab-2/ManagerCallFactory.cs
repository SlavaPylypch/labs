using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public class ManagerCallFactory : ISubscriptionFactory
    {
        public ISubscription CreateSubscription(bool isFamilyCustomer)
        {
            if (isFamilyCustomer)
            {
                return new DomesticSubscription();
            }
            else
            {
                return new PremiumSubscription();
            }
        }
    }
}
