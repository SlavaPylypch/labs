using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class IntermediateSupportHandler : SupportHandler
    {
        protected override bool CanHandle(string issue)
        {
            return issue == "2";
        }

        protected override void Handle(string issue)
        {
            Console.WriteLine("Intermediate support resolved your issue.");
        }
    }
}
