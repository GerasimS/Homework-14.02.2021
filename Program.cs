using System;

namespace Reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string of characters");
            string str1 = Console.ReadLine();
            for(int i = str1.Length - 1; i >= 0; i--)
            {
                Console.Write(str1[i]);
            }
            
        }
    }
}
