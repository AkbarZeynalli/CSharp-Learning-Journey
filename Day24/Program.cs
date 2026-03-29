namespace Day24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            if(!int.TryParse(Console.ReadLine(),out int number1))
            {
                Console.WriteLine("Invalid Input!");
                return;
            }

            Console.Write("Enter the second number: ");
            if (!int.TryParse(Console.ReadLine(), out int number2))
            {
                Console.WriteLine("Invalid Input!");
                return;
            }

            int ebob = 1;
            int min_number = Math.Min(number1, number2);

            for(int i  = min_number; min_number >= 0; i--)
            {
                if(number1 %2 ==0 && number2 %2 == 0)
                {
                    ebob = i;
                    break;
                }
            }

            int ekob = (number1 * number2) / ebob;

            Console.WriteLine($"\n GCD(Greatest Common Divistor)EBOB: {ebob}");
            Console.WriteLine($"\n LCM(Least Common Multiple)EKOB: {ekob}");
        }
    }
}
