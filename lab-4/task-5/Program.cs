using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var document = new TextDocument();
            var editor = new TextEditor(document);

            editor.Write("Hello, ");
            editor.ShowDocument();

            editor.Write("World!");
            editor.ShowDocument();

            editor.Undo();
            editor.ShowDocument();

            editor.Undo();
            editor.ShowDocument();
        }
    }
}
