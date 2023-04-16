using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Unit2DiceRoller;

public class RollDice
{

    public static int DiceRoll(int sides)
    {
        Random rnd = new Random();
        return rnd.Next(1, sides + 1);
    }

    public static string GetCombo(int d1, int d2)
    {
        if (d1 == 1 && d2 == 1)
        {
            return "Snake Eyes";
        }
        else if (d1 == 1 && d2 == 2)
        {
            return "Ace Deuce";
        }
        else if (d1 == 6 && d2 == 6)
        {
            return "Box Cars";
        }
        else
        {
            return "";
        }
    }

    public static string GetTotal(int d1, int d2)
    {
        int total = d1 + d2;
        if (total == 7 || total == 11)
        {
            return "Win";
        }
        else if (total == 2 || total == 3 || total == 12)
        {
            return "Craps";
        }
        else
        {
            return "";
        }
    }
}
