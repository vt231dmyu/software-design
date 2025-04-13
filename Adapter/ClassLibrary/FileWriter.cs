using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class FileWriter
    {
        private string _filePath;

        public FileWriter(string fileName = "log.txt")
        {
            string solutionRootPath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "..", "..", ".."));
            _filePath = Path.Combine(solutionRootPath, fileName);
        }

        public void Write(string message)
        {
            File.AppendAllText(_filePath, message);
        }

        public void WriteLine(string message)
        {
            File.AppendAllText(_filePath, message + Environment.NewLine);
        }
    }
}
