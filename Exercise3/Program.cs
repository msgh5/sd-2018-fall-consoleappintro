using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            var validOptions = new List<int> { 1, 2, 3, 4 };
            int firstNumber;
            int secondNumber;
            int operation;
            int finalResult;
            string keyboardInput;

            //Asking for the first input
            Console.WriteLine("Input the first number:");
            firstNumber = GetInputFromUser();

            //Asking for the second input
            Console.WriteLine("Input the second number:");
            secondNumber = GetInputFromUser();

            //Asking for the operation
            Console.WriteLine("Input the operation:");
            Console.WriteLine("1 - Add");
            Console.WriteLine("2 - Subtract");
            Console.WriteLine("3 - Multiply");
            Console.WriteLine("4 - Divide");

            keyboardInput = Console.ReadLine();

            while (!int.TryParse(keyboardInput, out operation) || 
                !validOptions.Contains(operation))
            {
                Console.WriteLine("Invalid input. Only numbers 1-4 are allowed.");
                keyboardInput = Console.ReadLine();
            }

            //Perform the operation
            var calculator = new Calculator(firstNumber, secondNumber);
            
            if (operation == (int)Operation.Add)
            {
                finalResult = calculator.Add();
            }
            else if (operation == (int)Operation.Subtract)
            {
                finalResult = calculator.Subtract();
            }
            else if (operation == (int)Operation.Multiply)
            {
                finalResult = calculator.Multiply();
            }
            else if (operation == (int)Operation.Divide)
            {
                finalResult = calculator.Divide();
            }
            else
            {
                throw new Exception("OOOPS! The program shouldn't get here.");
            }

            //Display the final result
            Console.WriteLine($"The result is: {finalResult}");
            Console.ReadLine();
        }

        public static int GetInputFromUser()
        {
            var keyboardInput = Console.ReadLine();
            int number;

            while (!int.TryParse(keyboardInput, out number))
            {
                Console.WriteLine("Invalid input. Only numbers are allowed");
                keyboardInput = Console.ReadLine();
            }

            return number;
        }
    }
}
