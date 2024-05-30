using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public interface ISupportHandler
    {
        void HandleRequest(string issue);
        ISupportHandler SetNext(ISupportHandler nextHandler);
    }
}
