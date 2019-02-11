using System;

namespace CarExercise
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Registration { get; set; }
        public int Year { get; set; }
        public decimal CurrentValue { get; set; }

        public Car(string make, string model, string registration,
            int year, decimal currentValue)
        {
            Make = make;
            Model = model;
            Registration = registration;
            Year = year;
            CurrentValue = currentValue;
        }

        public void Drive()
        {
            Console.WriteLine($"{Model} - Vroom! Vroom! Vroom!");
        }

        public override string ToString()
        {
            return $"{Make} - {Model} - {Registration}" +
              $" - {Year} - {CurrentValue}";
        }
    }
}
