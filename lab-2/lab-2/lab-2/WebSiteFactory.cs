﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public class WebSiteFactory : ISubscriptionFactory
    {
        public ISubscription CreateSubscription(bool prefersSports)
        {
            if (prefersSports)
            {
                return new PremiumSubscription();
            }
            else
            {
                return new DomesticSubscription();
            }
        }
    }

}
