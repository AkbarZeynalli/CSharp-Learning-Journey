namespace Day8
{

    public class Person()
    {
        public string Name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Ekber";
            Person p2 = p1;

            p1.Name = "Selim";
            Console.WriteLine("p1: " + p1.Name);
            Console.WriteLine("P2: " + p2.Name);
        }
    }
}
