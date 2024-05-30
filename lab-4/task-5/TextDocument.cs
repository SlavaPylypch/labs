using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    public class TextDocument
    {
        public string Content { get; set; }

        public Memento Save()
        {
            return new Memento(Content);
        }

        public void Restore(Memento memento)
        {
            Content = memento.State;
        }

        public override string ToString()
        {
            return Content;
        }
    }
}
