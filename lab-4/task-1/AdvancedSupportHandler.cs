using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class AdvancedSupportHandler : SupportHandler
    {
        protected override bool CanHandle(string issue)
        {
            return issue == "3";
        }

        protected override void Handle(string issue)
        {
            Console.WriteLine("Advanced support resolved your issue.");
        }
    }
}
