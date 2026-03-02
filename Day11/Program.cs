namespace Day11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Math 
            //Math m = new Math();    
            //Console.WriteLine("PI Value: "+Math.PI);
            //Console.WriteLine("Euler's number: "+Math.E);

            //Abs
            //int minusValue = -10;
            //int plusValue = Math.Abs(minusValue);
            //Console.WriteLine(plusValue);

            //Pow
            //int powValue  = (int)Math.Pow(minusValue,2);
            //Console.WriteLine(powValue);


            //WHILE LOOP
            //int a = 1;
            //while (a <= 10)
            //{
            //    Console.WriteLine($"Number: {a}");
            //    a++;
            //}

            //string password = "";
            //while(password != "123")
            //{
            //    Console.Write("Enter Password: ");
            //    password = Console.ReadLine() ?? "Melumat daxil edilmedi!";
            //}
            //Console.WriteLine("Access");



            //string testExit = "";
            //while (true)
            //{
            //    Console.Write("Çıxmaq üçün 'exit' yaz: ");
            //    testExit = Console.ReadLine();  
            //    if(testExit =="exit")
            //        break;
            //}
            //Console.WriteLine("Sistemdən çıxış olundu .");


            char choose = 'y';
            int i = 1;
            int sum = 0;
            while(choose == 'y')
            {
                Console.Write($"Number {i}:");
                sum += Convert.ToInt32(Console.ReadLine());

                Console.Write("Do you want to continue(y/n)");
                choose =Convert.ToChar(Console.ReadLine());
                if (choose == 'n')
                    break;
                i++;
            }
            Console.WriteLine($"The sum of {i} numbers {sum}");
        }
    }
}
