using System;
using Unit2DiceRoller;
using static Unit2DiceRoller.RollDice;

{
    bool keepPlaying = true;
    while (keepPlaying)
    {
        Console.Write("How many sides does each die have? ");
        int sides = 0;
        try
        {
            sides = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            continue;
        }
        if (sides < 1)
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
            continue;
        }

        int die1 = RollDice.DiceRoll(sides);
        int die2 = RollDice.DiceRoll(sides);
        Console.WriteLine("Die 1: " + die1);
        Console.WriteLine("Die 2: " + die2);
        Console.WriteLine("Total: " + (die1 + die2));

        string combo = RollDice.GetCombo(die1, die2);
        if (sides == 6 && combo != "")
        {
            Console.WriteLine(combo + "!");
        }

        string total = RollDice.GetTotal(die1, die2);
        if (sides == 6 && total != "")
        {
            Console.WriteLine(total + "!");
        }

        Console.Write("Roll again? (y/n) ");
        string answer = Console.ReadLine().ToLower();
        if (answer != "y" && answer != "yes")
        {
            keepPlaying = false;
        }
    }
}