namespace Day20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ARRAY:

            //int[] oldArray = { 10, 20, 30 };
            //int[] newArray = new int[4];
            //Array.Copy(oldArray, newArray, 3);
            //newArray[3] = 40;
            //foreach (int i in newArray)
            //    Console.Write(i + " ");
            //Bu şəkildə nəsə əlavə etmək zəhmətlidi onun yerinə LİST lərdən isdifadə edə bilərik

            //LIST:
            List<int> numbers = new List<int>();

            numbers.Add(10);
            numbers.Add(20);

            foreach (var item in numbers)
                Console.WriteLine(item);

            numbers.Remove(10);
            foreach(var item in numbers)
                Console.WriteLine(item);


        }
    }
}
