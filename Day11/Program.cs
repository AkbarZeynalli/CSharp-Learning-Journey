namespace Day11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Math 
            //Math m = new Math();    
            Console.WriteLine("PI Value: "+Math.PI);
            Console.WriteLine("Euler's number: "+Math.E);

            //Abs
            int minusValue = -10;
            int plusValue = Math.Abs(minusValue);
            Console.WriteLine(plusValue);

            //Pow
            int powValue  = (int)Math.Pow(minusValue,2);
            Console.WriteLine(powValue);
        }
    }
}
