using System;

namespace KStalnacke.Coffee
{
    class Program
    {
        // Determines the amount of coffee beans needed based on the number of cups.
        private static int CalculateGrams(int numberOfCups)
        {
            int amountOfCoffee = numberOfCups * 125 / 15;
            return amountOfCoffee;
        }

        // Uses a function based on data from r/JamesHoffman to calculate the Wilfa Uniform grind setting.
        private static double CalculateGrind(int grams)
        {
            double grindSize = Math.Floor(0.005 * Math.Pow(grams, 2) - 0.16 * grams + 21.24);
            return grindSize;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of cups you want to use:");
            int numberOfCups = Convert.ToInt16(Console.ReadLine());
            int gramsNeeded = CalculateGrams(numberOfCups);
            Console.WriteLine($"For {numberOfCups} cups of coffee, you will need {gramsNeeded} grams of coffee beans. The beans should be grinded using setting {CalculateGrind(gramsNeeded)}.");
            Console.ReadKey();
        }
    }
}