using System;

namespace KStalnacke.Coffee
{
    class Program
    {
        private static int CalculateGrams(int numberOfCups)
        {
            // Determines the amount of coffee beans needed based on the number of cups.
            int amountOfCoffee = numberOfCups * 125 / 15;
            return amountOfCoffee;
        }

        private static int CalculateGrind(int grams)
        {
            int[] gramThresholds = { 25, 50, 60 };
            int[] grindSizes = { 18, 22, 26 };

            for (int i = 0; i < gramThresholds.Length; i++)
            {
                if (grams <= gramThresholds[i])
                {
                    return grindSizes[i];
                }
            }

            // Handle the case when the grams are larger than all thresholds
            return grindSizes[gramThresholds.Length - 1];
        }

        static void Main(string[] args)
        {
            Console.Title = "Coffee Calculator";
            Console.WriteLine("Enter the number of cups:");
            int numberOfCups = Convert.ToInt32(Console.ReadLine());

            int gramsOfBeans = CalculateGrams(numberOfCups);
            int grindSize = CalculateGrind(gramsOfBeans);

            Console.WriteLine($"For {numberOfCups} cups of coffee, you should use {gramsOfBeans} grams of beans.");
            Console.WriteLine($"You should use grind size {grindSize} for this batch size.");

            Console.ReadLine();
        }
    }
}