using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("Car1", "Model1", "Registration1", 2014, 999999);
            var car2 = new Car("Car2", "Model2", "Registration2", 2013, 888888);
            var car3 = new Car("Car3", "Model3", "Registration3", 2015, 777777);

            //Console.WriteLine($"{car1.Make} - {car1.Model} - {car1.Registration}" +
            //  $" - {car1.Year} - {car1.CurrentValue}");

            //Console.WriteLine($"{car2.Make} - {car2.Model} - {car2.Registration}" +
            //  $" - {car2.Year} - {car2.CurrentValue}");

            //Console.WriteLine($"{car3.Make} - {car3.Model} - {car3.Registration}" +
            //  $" - {car3.Year} - {car3.CurrentValue}");

            Console.WriteLine($"{car1.ToString()}");
            Console.WriteLine($"{car2.ToString()}");
            Console.WriteLine($"{car3.ToString()}");


            Console.ReadLine();
        }
    }
}
