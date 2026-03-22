namespace Day19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ARRAYS

            //Console.WriteLine("Hello, World!");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] numbers2 = numbers[2..];
            foreach(int number in numbers2) 
                Console.WriteLine(number);


            //Multidimensional Arrays:
            int[,] multiNumbers = { { 1, 2, 3, }, { 4, 5, 6 }, { 7, 8, 9 } };
            foreach(int number in multiNumbers)
                Console.WriteLine(number);
        }
    }
}
