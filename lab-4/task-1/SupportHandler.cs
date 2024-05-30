using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public abstract class SupportHandler : ISupportHandler
    {
        private ISupportHandler _nextHandler;

        public ISupportHandler SetNext(ISupportHandler nextHandler)
        {
            _nextHandler = nextHandler;
            return nextHandler;
        }

        public void HandleRequest(string issue)
        {
            if (CanHandle(issue))
            {
                Handle(issue);
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(issue);
            }
            else
            {
                Console.WriteLine("No support handler found for your issue. Please try again.");
                Program.StartSupportProcess();
            }
        }

        protected abstract bool CanHandle(string issue);
        protected abstract void Handle(string issue);
    }
}
