
namespace Day23
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Daxil edilən ədədə qədər olan sadə ədədləri göstər

            Console.Write("Enter a number: ");
            if (!int.TryParse(Console.ReadLine(), out int values))
            {
                Console.WriteLine("Invalid number!");
                return;
            }

            if (values < 2)
            {
                Console.WriteLine("Not a prime number!");
                return;
            }

            Console.Write("2 ");


            for (int number = 3; number <= values; number += 2)
            {
                bool isPrime = true;

                for (int i = 2; i <= Math.Sqrt(values); i++)
                {
                    if (number % 2 == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    Console.Write($"{number} ");
            }
        }
    }
}
