using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SmartTextChecker : IService
    {
        private readonly IService _reader;

        public SmartTextChecker(IService reader)
        {
            _reader = reader;
        }

        public char[][] ReadFile(string fileName)
        {
            try
            {
                Console.WriteLine($"[LOG] Attempting to open file.");

                char[][] content = _reader.ReadFile(fileName);

                Console.WriteLine($"[LOG] File read successfully.");
                Console.WriteLine($"[LOG] Lines: {content.Length}, Characters: {TotalChars(content)}.");
                Console.WriteLine("[LOG] File closed.");

                return content;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[LOG] Error reading file: {ex.Message}");
                return Array.Empty<char[]>();
            }
        }

        private int TotalChars(char[][] content)
        {
            int count = 0;
            foreach (var line in content)
            {
                count += line.Length;
            }
            return count;
        }
    }
}
