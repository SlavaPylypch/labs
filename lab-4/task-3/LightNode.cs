using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    public abstract class LightNode
    {
        private List<EventListener> eventListeners = new List<EventListener>();

        public void AddEventListener(string eventType, Action handler)
        {
            eventListeners.Add(new EventListener(eventType, handler));
        }

        public void RemoveEventListener(string eventType, Action handler)
        {
            eventListeners.RemoveAll(el => el.EventType == eventType && el.Handler == handler);
        }

        public void DispatchEvent(string eventType)
        {
            foreach (var listener in eventListeners)
            {
                if (listener.EventType == eventType)
                {
                    listener.Handler.Invoke();
                }
            }
        }

        public abstract string OuterHTML { get; }
        public abstract string InnerHTML { get; }
    }
}
