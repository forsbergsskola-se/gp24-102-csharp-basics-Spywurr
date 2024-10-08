using System;

class Program
{
    static void Main(string[] args)
    {

        Random rnd = new Random();
        int min = 1;
        int max = 100;
        int guess = 0;
        int number = rnd.Next(min, max + 1);
        int guesses = 1;


        Console.WriteLine($"Pssssst, the correct number is {number}");
        Console.WriteLine($"I have picked a number ({min}-{max}). It's your turn to guess it!");
        
            
    tryAgain:
            {
            guess = Convert.ToInt32(Console.ReadLine());
            
            if (guesses >= 10)
            {
                goto gameOver;
            }

            if (guess > max)
            {
                Console.WriteLine($"Too high, you need to write a number between {min}-{max}. Try again!");
                goto tryAgain;
            }

            if (guess < min)
            {
                Console.WriteLine($"Too low, you need to write a number between {min}-{max}. Try again!");
                goto tryAgain;
            }

            if (guess > number && guess < max + 1)
            {
                Console.WriteLine($"Nope! My number is Smaller! Attempt #{guesses}");
                guesses++;
                goto tryAgain;
            }
            if (guess < number && guess >= min)
            {
                Console.WriteLine($"Nope! My number is Greater! Attempt #{guesses}");
                guesses++;
                goto tryAgain;
            }
            if (guess == number)
            {
                Console.WriteLine("That's the number! Well played");
                Console.WriteLine($"That took {guesses} attempts!");
            }

    gameOver:
    {
        Console.WriteLine("Game over!");
    }
            
    }
        
    }      
}
