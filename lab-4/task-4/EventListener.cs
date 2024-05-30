using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    public class EventListener
    {
        public string EventType { get; }
        public Action Handler { get; }

        public EventListener(string eventType, Action handler)
        {
            EventType = eventType;
            Handler = handler;
        }
    }
}
