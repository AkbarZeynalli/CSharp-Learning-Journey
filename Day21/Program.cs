namespace Day21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Number guessing game (Sayı təxmin oyunu)

            Random rnd = new Random();
            int target = rnd.Next(1, 101);
            int guess;
            int attempt = 5;
            int score = 100;

            while (attempt > 0)
            {
                Console.Write("Enter your guess between 1 and 100: ");
                if (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("\nInvalid Input.");
                    continue;
                }
                if (guess < 1 || guess > 100)
                {
                    Console.WriteLine("\nPlease enter a number between 1 and 100!");
                    continue;
                }
                if (guess < target)
                {
                    Console.WriteLine("\nHigher");
                    score -= 10;
                }
                else if (guess > target)
                {
                    Console.WriteLine("\nLower");
                    score -= 10;
                }
                else
                {
                    Console.WriteLine("\nYou just won!");
                    Console.WriteLine($"Socre: {score}");
                    return;
                }
                attempt--;
                Console.WriteLine($"\nRemaining attempts:{attempt}");
                Console.WriteLine($"\nCurrent score: {score}");
            }
        }
    }
}
