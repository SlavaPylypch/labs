using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            ILogger consoleLogger = new ConsoleLogger();
            consoleLogger.Log("This is a log message.");
            consoleLogger.Error("This is an error message.");
            consoleLogger.Warn("This is a warning message.");

            FileWriter fileWriter = new FileWriter("log.txt");
            ILogger fileLogger = new FileLogger(fileWriter);
            fileLogger.Log("This is a log message.");
            fileLogger.Error("This is an error message.");
            fileLogger.Warn("This is a warning message.");
            Console.ReadKey();
        }
    }
}
