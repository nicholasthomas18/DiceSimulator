using DiceSimulator;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Dice Rolling Simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        int totDiceRolls = int.Parse(Console.ReadLine());

        DiceRoller rollDice = new DiceRoller();
        
        rollDice.RollnTally(totDiceRolls);

        rollDice.DisplayResults(totDiceRolls);
    }
}