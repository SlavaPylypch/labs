using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public interface ISubscription
    {
        decimal MonthlyFee { get; }
        int MinimumPeriod { get; }
        List<string> Channels { get; }
        List<string> Features { get; }
        void ShowDetails();
    }
}
