internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Give me a number of seconds: ");
        int input = Convert.ToInt32(Console.ReadLine());
        int seconds = input % 60;
        int minutes = input % 3600 / 60;
        int hours = input % 86400 / 3600;
        int days = input / 86400;
        Console.WriteLine($"Seconds: {seconds}");
        Console.WriteLine($"Minutes: {minutes}");
        Console.WriteLine($"Hours: {hours}");
        Console.WriteLine($"Days: {days}");
        Console.WriteLine($"{days}.{hours}:{minutes}:{seconds}");
        double inputConverted = Convert.ToDouble(input);
        double daysConverted = inputConverted / 86400;
        Console.WriteLine($"In total, that's {daysConverted}");

    }
}