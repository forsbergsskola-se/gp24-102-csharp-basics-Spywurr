using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int min = 1;
        int max = 3;
        int matchesLeft = 24;
        int matchesDrawn;
        bool playerTurn = true;

        Random rand = new Random();

        Console.WriteLine("Welcome to Nim!");
        Console.WriteLine("Here are the rules to the game:");
        Console.WriteLine("1. Players take turns to draw matches.");
        Console.WriteLine("2. Each player may draw 1,2 or 3 matches (not more or less)");
        Console.WriteLine("3. The Player who has to take last match loses.");
        Console.WriteLine("");

        while (matchesLeft > 0 || playerTurn)
        {
            //Users turn to draw matches
            playerTurn = true;
            Console.WriteLine(new string('|', matchesLeft) + $" There are ({matchesLeft}) matches left.");
            Console.WriteLine("How many matches would you like to draw?");
            string playerDraw = Console.ReadLine();
            int.TryParse(playerDraw, out matchesDrawn);

            if (matchesDrawn <= Math.Min(max, matchesLeft) && matchesDrawn >= min)
            {
                matchesLeft = matchesLeft - matchesDrawn;
                playerTurn = false;
            }
            else
            {
                Console.WriteLine($"You need to draw between {min}and {Math.Min(matchesLeft, max)}matches, try again!");
            }

            //AI's turn to draw matches
            if (matchesLeft >= 1)
            {
                int aiDraw = rand.Next(min, Math.Min(max + 1, matchesLeft));
                Console.WriteLine($"AI Draws {aiDraw} matches.");
                matchesLeft = matchesLeft - aiDraw;
            }
            if (matchesLeft == 0 && playerTurn)
            {
                Console.WriteLine("You lose!");
                break;
            }
            if (matchesLeft == 0 && !playerTurn)
            {
                Console.WriteLine("You win!");
                break;
            }

        }
    }
}