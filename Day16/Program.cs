namespace Day16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber  = random.Next(100,150);
            double randomNumber2 = random.NextDouble()*10;
            Console.WriteLine($"Random double number: {randomNumber2}");
            Console.WriteLine(randomNumber);

        }
    }
}
