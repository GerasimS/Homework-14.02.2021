using System;
using System.Collections.Generic;

namespace DoorLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> doorLog = new Dictionary<string, int>();
            
            char swt = '1';
            string name;

            while (swt != '~')
            {
                Console.WriteLine("Enter 'I' to get in, 'O' to get out or '~' to close the program: ");
                swt = char.Parse(Console.ReadLine());
                switch (swt)
                {
                    case 'I':
                        Console.WriteLine("Enter the name of the person coming in: ");
                        name = Console.ReadLine();
                        if(doorLog.ContainsKey(name) == false)
                        {
                            doorLog.Add(name, 1);
                            Console.WriteLine("The person is logged in!");
                        }
                        else if(doorLog.ContainsKey(name) && doorLog[name] == 1)
                        {
                            Console.WriteLine("This person is already in!");
                        }
                        else
                        {
                            doorLog[name] = 1;
                            Console.WriteLine("The person is logged in!");
                        }

                        break;
                    case 'O':
                        Console.WriteLine("Enter the name of the person going out: ");
                        name = Console.ReadLine();
                        if (doorLog.ContainsKey(name) == false)
                        {
                            Console.WriteLine("There is no person called " + name + " in the room!");
                        }
                        else if (doorLog.ContainsKey(name) && doorLog[name] == 0)
                        {
                            Console.WriteLine("This person is already out!");
                        }
                        else
                        {
                            doorLog[name] = 0;
                            Console.WriteLine("The person went out!");
                        }
                        break;
                    case '~':
                        break;
                    default:
                        Console.WriteLine("Incorrect input!");
                        break;
                }
            }
        }
    }
}
