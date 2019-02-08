using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var lstOfLetters = new List<string>();

            Console.WriteLine("Type first letter");
            lstOfLetters.Add(Console.ReadLine());

            Console.WriteLine("Type second letter");
            lstOfLetters.Add(Console.ReadLine());

            Console.WriteLine("Type third letter");
            lstOfLetters.Add(Console.ReadLine());

            Console.WriteLine("Type forth letter");
            lstOfLetters.Add(Console.ReadLine());

            Console.WriteLine("Type fifth letter");
            lstOfLetters.Add(Console.ReadLine());

            lstOfLetters.Reverse();

            foreach(var element in lstOfLetters)
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();
        }
    }
}
