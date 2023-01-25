using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Unit2DiceRoller
{
    public class RollDice 
    {
        public static int DiceRoll() // Declaring the method for the random number generator
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 7); // Creates a random number between 1 and 6
            return num; // returns the number to the Program when method is called
        }
        public static string DiceCombinations(int a, int b) // Delcaring method for control statement. When called in the Program, method will determine which statement to return. 
        {
            if (a == 1 && b == 1)
            {
                return "Snake Eyes";
            }
            else if (a == 1 && b == 2 || a == 2 && b == 1)
            {
                return "Ace Deuce";
            }
            else if (a == 6 && b == 6)
            {
                return "Box Cars";
            }
            else if (a + b == 7)
            {
                return "You Win!";
            }
            else if (a + b == 11)
            {
                return "You Win!";
            }
            else if (a + b == 2)
            {
                return "Craps!";
            }
            else if (a + b == 3)
            {
                return "Craps!";
            }
            else if (a + b == 12)
            {
                return "Craps!";
            }
            else return "";
        }
    }
}