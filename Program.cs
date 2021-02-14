using System;
using System.Text.RegularExpressions;

namespace Replace_words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word you want to remove");
            string bword = Console.ReadLine();
            if(bword.Contains(' '))
            {
                bword = bword.Remove(bword.LastIndexOf(' '));
            }
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            string stCount = "*";
            for (int i = bword.Length - 1; i > 0; i--)
            {
                stCount = stCount + "*";
            }
            Console.WriteLine(Regex.Replace(text, bword, stCount));
        }
    }
}
