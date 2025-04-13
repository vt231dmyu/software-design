using ClassLibrary;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsageProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName1 = "example.txt";
            string fileName2 = "secret_file.txt";

            IService original = new SmartTextReader();
            IService checker = new SmartTextChecker(original);
            IService locker = new SmartTextReaderLocker(checker, @"secret.*\.txt");

            Console.WriteLine("=== Reading allowed file ===");
            locker.ReadFile(fileName1);

            Console.WriteLine("\n=== Reading restricted file ===");
            locker.ReadFile(fileName2);
        }
    }
}
