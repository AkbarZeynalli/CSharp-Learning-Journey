namespace Day17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            int[] arr1 = { 1, 2, 3 };
            foreach(int item in arr1)
                Console.WriteLine($"Item: {item}");


            string info = "Ekber bu il her şeyi bacaracaq! hərkəsə və hərşeyə rəğmən";
            foreach (int itm in info)
                Console.WriteLine($"INFO: {itm}");
        }
    }
}
