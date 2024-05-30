using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartTextReader reader = new SmartTextReader();

            SmartTextChecker checker = new SmartTextChecker(reader);
            char[][] data = checker.ReadFile("example.txt");
            DisplayData(data);

            SmartTextReaderLocker locker = new SmartTextReaderLocker(reader, @"restricted\.txt$");
            data = locker.ReadFile("example.txt"); // Доступ дозволено
            DisplayData(data);

            data = locker.ReadFile("restricted.txt"); // Доступ заборонено
            DisplayData(data);
        }

        static void DisplayData(char[][] data)
        {
            if (data != null)
            {
                foreach (var line in data)
                {
                    Console.WriteLine(new string(line));
                }
            }
        }
    }
}
