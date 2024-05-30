using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public class MobileAppFactory : ISubscriptionFactory
    {
        public ISubscription CreateSubscription(bool promotionAvailable)
        {
            if (promotionAvailable)
            {
                return new EducationalSubscription();
            }
            else
            {
                return new DomesticSubscription();
            }
        }
    }
}
