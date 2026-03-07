namespace Day13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //iç içə döngülər;


            //for (int i = 1; i <=2; i++)
            //{
            //    Console.WriteLine($"{i}. döngü: ");
            //    for (int j = 1; j <=3; j++)
            //    {
            //        Console.WriteLine($"{j}.\t döngü");
            //    }
            //}


            //İstifadəçi N daxil etsin. for döngüləri ilə N × N kvadrat çap et.
            //Console.Write("Enter number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < number; i++)
            //{
            //    for (int j = 0; j <=number; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("+");
            //    }
            //    Console.WriteLine();
            //}


            //Pramida Loop 
            Console.Write("N ədədini daxil edin: ");
            int number  = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=number; i++)
            {
                //boşluq:
                for (int j = 1; j < number - i; j++)
                {
                    Console.Write(" ");
                }

                //Simvol:
                for (int k = 1; k <=2*i-1; k++)
                {
                    Console.Write("+");
                }
                Console.WriteLine();
            }

        }
    }
}
