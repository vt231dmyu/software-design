using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace UsageProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Console Logger ===");
            ILogger consoleLogger = new Logger();
            consoleLogger.Log("This is a log message");
            consoleLogger.Error("This is an error message");
            consoleLogger.Warn("This is a warning message");

            Console.WriteLine("\n=== File Logger (Adapter) ===");
            FileWriter fileWriter = new FileWriter();
            ILogger fileLogger = new FileLoggerAdapter(fileWriter);
            fileLogger.Log("File log message");
            fileLogger.Error("File error message");
            fileLogger.Warn("File warning message");

            Console.WriteLine("\n=== Direct usage of FileWriter ===");
            fileWriter.Write("This line is written using Write (without newline). ");
            fileWriter.WriteLine("This line is written using WriteLine (with newline).");

            Console.WriteLine("\nAll messages have been written to the console and to log.txt");
        }
    }
}
