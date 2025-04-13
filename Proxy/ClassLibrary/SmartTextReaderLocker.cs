using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SmartTextReaderLocker : IService
    {
        private readonly IService _reader;
        private readonly Regex _blockedPattern;

        public SmartTextReaderLocker(IService reader, string pattern)
        {
            _reader = reader;
            _blockedPattern = new Regex(pattern, RegexOptions.Compiled);
        }

        public char[][] ReadFile(string fileName)
        {
            if (_blockedPattern.IsMatch(fileName))
            {
                Console.WriteLine("Access denied!");
                return Array.Empty<char[]>();
            }

            return _reader.ReadFile(fileName);
        }
    }
}
