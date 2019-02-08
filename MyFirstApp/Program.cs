using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your username?");

            //byte myByte = 0;

            //dynamic a = 1;
            //a = "asdasd";

            //string username = "sadas dsa assad asd";
            //var username2 = 2;

            //char myChar = 'C';

            //int myNumber = 1;
            //var myNumber2 = 2;

            //long myLong = 1;

            //double myDouble = 1.3;
            //float myFloat = 1.3f;
            //decimal myDecimal = 1.3m;

            //bool myBoolean = true;
            //bool myBooleanFalse = false;

            //username = Console.ReadLine();

            //Console.WriteLine("Your username is: " + username);

            //Console.ReadLine();

            //Console.WriteLine("Please type a number");

            //var userInput = Console.ReadLine();

            //var number = Convert.ToInt32(userInput);

            //if (number == 1)
            //{
            //    Console.WriteLine("Congratz, you've won!");
            //}
            //else if (number == 2)
            //{
            //    Console.WriteLine("You've typed 2");
            //}
            //else
            //{
            //    Console.WriteLine("You've lost");
            //}

            //Console.ReadLine();

            //for (var i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"The loop is {i}");
            //}

            var userInput = "1";

            while(userInput == "0")
            {
                Console.WriteLine("Type a number to continue:");
                Console.WriteLine("1 - Do Operation A");
                Console.WriteLine("2 - Do Operation B");
                Console.WriteLine("3 - Do Operation C");
                Console.WriteLine("0 - Exit");

                userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    Console.WriteLine("Doing Operation A");
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("Doing Operation B");
                }
                else if (userInput == "3")
                {
                    Console.WriteLine("Doing Operation C");
                }
                else if (userInput == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }

            Console.ReadLine();

        }
    }
}
