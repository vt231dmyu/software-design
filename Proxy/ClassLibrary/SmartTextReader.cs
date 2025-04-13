using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SmartTextReader : IService
    {
        public char[][] ReadFile(string fileName)
        {
            string solutionRootPath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", ".."));
            string filePath = Path.Combine(solutionRootPath, fileName);

            if (!File.Exists(filePath))
                throw new FileNotFoundException($"File {fileName} not found.");

            string[] lines = File.ReadAllLines(filePath);
            char[][] result = new char[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                result[i] = lines[i].ToCharArray();
            }
            return result;
        }
    }
}
