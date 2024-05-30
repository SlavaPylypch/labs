using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    public class TextEditor
    {
        private readonly TextDocument _document;
        private readonly Caretaker _caretaker;

        public TextEditor(TextDocument document)
        {
            _document = document;
            _caretaker = new Caretaker();
        }

        public void Write(string text)
        {
            _caretaker.SaveState(_document.Save());
            _document.Content += text;
        }

        public void Undo()
        {
            var memento = _caretaker.RestoreState();
            if (memento != null)
            {
                _document.Restore(memento);
            }
        }

        public void ShowDocument()
        {
            Console.WriteLine(_document);
        }
    }
}
