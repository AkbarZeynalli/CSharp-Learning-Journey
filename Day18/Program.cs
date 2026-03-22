namespace Day18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberArr = { 10, 20, 30, };
            foreach (int number in numberArr)
            {
                Console.WriteLine(number);
            }

            string[] fruits = { "apple", "strawberry", "melon", "watermelon", "orange", "grape" };
            Console.WriteLine(fruits[1]);
            fruits[1] = "banana";
            Console.WriteLine(fruits[1]);
            Console.WriteLine(fruits.Length);

            foreach(string number in fruits)
                 Console.WriteLine(number); 

            for(int i = 0; i < fruits.Length; i++)
                Console.WriteLine(fruits[i]);
        }
    }
}
