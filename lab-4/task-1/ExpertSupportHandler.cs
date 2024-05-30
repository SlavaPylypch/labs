using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class ExpertSupportHandler : SupportHandler
    {
        protected override bool CanHandle(string issue)
        {
            return issue == "4";
        }

        protected override void Handle(string issue)
        {
            Console.WriteLine("Expert support resolved your issue.");
        }
    }
}
