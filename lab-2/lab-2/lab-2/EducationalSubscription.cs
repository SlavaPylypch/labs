using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public class EducationalSubscription : ISubscription
    {
        public decimal MonthlyFee { get; private set; }
        public int MinimumPeriod { get; private set; }
        public List<string> Channels { get; private set; }
        public List<string> Features { get; private set; }

        public EducationalSubscription()
        {
            MonthlyFee = 7.99m;
            MinimumPeriod = 6; // months
            Channels = new List<string> { "Educational", "Documentaries" };
            Features = new List<string> { "Basic Support", "Offline Access" };
        }

        public void ShowDetails()
        {
            Console.WriteLine("Educational Subscription:");
            Console.WriteLine($"Monthly Fee: {MonthlyFee}");
            Console.WriteLine($"Minimum Period: {MinimumPeriod} months");
            Console.WriteLine("Channels: " + string.Join(", ", Channels));
            Console.WriteLine("Features: " + string.Join(", ", Features));
        }
    }
}
