using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public class DomesticSubscription : ISubscription
    {
        public decimal MonthlyFee { get; private set; }
        public int MinimumPeriod { get; private set; }
        public List<string> Channels { get; private set; }
        public List<string> Features { get; private set; }

        public DomesticSubscription()
        {
            MonthlyFee = 9.99m;
            MinimumPeriod = 12; // months
            Channels = new List<string> { "News", "Entertainment", "Kids" };
            Features = new List<string> { "Basic Support" };
        }

        public void ShowDetails()
        {
            Console.WriteLine("Domestic Subscription:");
            Console.WriteLine($"Monthly Fee: {MonthlyFee}");
            Console.WriteLine($"Minimum Period: {MinimumPeriod} months");
            Console.WriteLine("Channels: " + string.Join(", ", Channels));
            Console.WriteLine("Features: " + string.Join(", ", Features));
        }
    }
}
