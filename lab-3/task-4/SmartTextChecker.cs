using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    public class SmartTextChecker : SmartTextReader
    {
        private readonly SmartTextReader _reader;

        public SmartTextChecker(SmartTextReader reader)
        {
            _reader = reader;
        }

        public new char[][] ReadFile(string filePath)
        {
            Console.WriteLine("Opening file: " + filePath);
            char[][] result = _reader.ReadFile(filePath);
            Console.WriteLine("File read successfully.");
            Console.WriteLine("File contains " + result.Length + " lines and " + CountCharacters(result) + " characters.");
            return result;
        }

        private int CountCharacters(char[][] data)
        {
            int count = 0;
            foreach (var line in data)
            {
                count += line.Length;
            }
            return count;
        }
    }

}
