namespace Day22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sadə ədədlərin tapılması oyunu: 
            Console.Write("Enter a number: ");
            if (!int.TryParse(Console.ReadLine(), out int inputNumber))
            {
                Console.WriteLine("Invalid Input!");
                return;
            }

            if (inputNumber <= 1)
            {
                Console.WriteLine("Not a prime number!");
            }
            
            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(inputNumber); i++)
            { 

                if(inputNumber %i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine(isPrime ? "Prime Number" : "Not a prime Number");

        }
    }
}
