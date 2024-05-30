using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class Program
    {
        static ISupportHandler supportChain;

        static void Main(string[] args)
        {
            SetUpChain();
            StartSupportProcess();
            Console.ReadKey();
        }

        private static void SetUpChain()
        {
            supportChain = new BasicSupportHandler();
            ISupportHandler intermediate = supportChain.SetNext(new IntermediateSupportHandler());
            ISupportHandler advanced = intermediate.SetNext(new AdvancedSupportHandler());
            advanced.SetNext(new ExpertSupportHandler());
        }

        public static void StartSupportProcess()
        {
            Console.WriteLine("Welcome to the support system.");
            Console.WriteLine("Press 1 for Basic support.");
            Console.WriteLine("Press 2 for Intermediate support.");
            Console.WriteLine("Press 3 for Advanced support.");
            Console.WriteLine("Press 4 for Expert support.");

            string issue = Console.ReadLine();
            supportChain.HandleRequest(issue);
        }
    }
}
