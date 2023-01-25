using Unit2DiceRoller; // granting access to the class for the methods.

Console.WriteLine("Welcome to the Grand Circus Casino!");
Console.WriteLine("Roll the die and test your luck!");

bool goagain = false; // setting bool value to false for loop
int roll = 1; // setting the value of the first roll
do // starting the loop for the dice roll
{
    int diceRoll1 = RollDice.DiceRoll(); // Calling the DiceRoll method and generating the first random number and storing the value.
    int diceRoll2 = RollDice.DiceRoll(); // Calling the DiceRoll method and generating the second random number and storing the value.

    Console.WriteLine("Roll " + roll); // Showing the user what roll they are on.
    Console.WriteLine($"You rolled a {diceRoll1} and {diceRoll2} ({diceRoll1 + diceRoll2} total)"); // Showing the user what they rolled and what it totaled to. 
    Console.WriteLine(Unit2DiceRoller.RollDice.DiceCombinations(diceRoll1, diceRoll2)); // Calling the control statements to let the user know what their dice combination means. 
    roll++; // Increasing the roll value by 1
    

    Console.WriteLine("Go Again? (y/n)"); // Asking the user if they would like to roll again. 
    string again = Console.ReadLine(); // Taking the users input

    if (again == "y" || again == "Y") // Control statement the sets the bool value for the loop. 
    {
        goagain = true;
    }

    else
    {
        goagain= false;
    }
} while (goagain);
