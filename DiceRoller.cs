using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceSimulator
{
    internal class DiceRoller
    {
        // Initialize randoms and an array to hold the results
        private Random random = new Random();
        private int[] rollTotal = new int[13];

        // Create a method to roll the die the number of times the user specified and tally the results
        public void RollnTally(int rolls)
        {
            int die1 = 0;
            int die2 = 0;
            int total = 0;

            // Roll the die & tally
            for (int i = 0; i < rolls; i++)
            {
                die1 = random.Next(1, 7);
                die2 = random.Next(1, 7);
                total = die1 + die2;

                rollTotal[total]++;
            }
        }

        public void DisplayResults(int rolls)
        {
            // Print out the header
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {rolls}");

            // For each dice number, print the array number, and the percentage it was rolled
            for (int i = 2; i <= 12; i++)
            {
                double percentage = (double)rollTotal[i] / rolls * 100;

                string stars = new string('*', (int)Math.Round(percentage));
                Console.WriteLine($"{i}: \t{stars}");
            }
            Console.WriteLine("Thank you for using the dice rolling simulator. Goodbye!");
        }
    }
}
