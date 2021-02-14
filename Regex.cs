using System;
using System.Text.RegularExpressions;

namespace Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameR = @"[A-Z]\w*\s[A-Z]\w*";
            string emailR = @"[a-zA-Z0-9.-]+@[a-zA-Z-]+\.(com|edu|bg|net|org)";
            string IPv4R = @"\d{1,3}.\d{1,3}.\d{1,3}.\d{1,3}";
        }
    }
}
