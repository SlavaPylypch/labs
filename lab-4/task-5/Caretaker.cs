using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    public class Caretaker
    {
        private readonly Stack<Memento> _history = new Stack<Memento>();

        public void SaveState(Memento memento)
        {
            _history.Push(memento);
        }

        public Memento RestoreState()
        {
            return _history.Count > 0 ? _history.Pop() : null;
        }
    }
}
