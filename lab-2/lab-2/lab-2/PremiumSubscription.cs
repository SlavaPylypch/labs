using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public class PremiumSubscription : ISubscription
    {
        public decimal MonthlyFee { get; private set; }
        public int MinimumPeriod { get; private set; }
        public List<string> Channels { get; private set; }
        public List<string> Features { get; private set; }

        public PremiumSubscription()
        {
            MonthlyFee = 19.99m;
            MinimumPeriod = 1; // month
            Channels = new List<string> { "News", "Entertainment", "Kids", "Sports", "Movies" };
            Features = new List<string> { "Premium Support", "Offline Access", "4K Streaming" };
        }

        public void ShowDetails()
        {
            Console.WriteLine("Premium Subscription:");
            Console.WriteLine($"Monthly Fee: {MonthlyFee}");
            Console.WriteLine($"Minimum Period: {MinimumPeriod} month");
            Console.WriteLine("Channels: " + string.Join(", ", Channels));
            Console.WriteLine("Features: " + string.Join(", ", Features));
        }
    }
}
