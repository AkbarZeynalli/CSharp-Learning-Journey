namespace Day14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //iç-içə döngülər

            //Console.Write("Enter number: ");
            //int inputNumber = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= inputNumber; i++)
            //{
            //    for (int j = 1; j <= i ; j++)
            //    {
            //        Console.Write($"{j}");
            //    }
            //    Console.WriteLine();
            //}



            Console.Write("Enter number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= inputNumber; i++)
            {
                for (int j = 1; j <= inputNumber; j++)
                {
                    if (i==1||i==inputNumber ||j==1||j==inputNumber)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
