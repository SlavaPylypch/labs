using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class BasicSupportHandler : SupportHandler
    {
        protected override bool CanHandle(string issue)
        {
            return issue == "1";
        }

        protected override void Handle(string issue)
        {
            Console.WriteLine("Basic support resolved your issue.");
        }
    }
}
