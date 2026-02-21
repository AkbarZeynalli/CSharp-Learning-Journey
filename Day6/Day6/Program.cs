//3 ədədin ən böyük ü ilə ən kiçiyini tap: 

int num1, num2, num3;

Console.WriteLine("Enter number 1: ");
if (!int.TryParse(Console.ReadLine(), out num1))
{
    Console.WriteLine("Invalid Input for first Number!");
    return;

}
Console.WriteLine("Enter number 2: ");
if (!int.TryParse(Console.ReadLine(), out num2))
{
    Console.WriteLine("Invalit input for second Number!");
        return;
}
Console.WriteLine("Enter number 3: ");
if (!int.TryParse(Console.ReadLine(), out num3))
{
    Console.WriteLine("Invalid input for third Number!");
    return;
}

int minNumber = num1;
int maxNumber = num1;

//MAX NUMBER SEARCH
if (num2>maxNumber)
    maxNumber = num2;
if (num3 > maxNumber)
    maxNumber = num3;

//MIN NUMBER SEARCH
if (num2<minNumber)
    minNumber = num2;
if(num3<minNumber)
    minNumber = num3;


//RESULT
Console.WriteLine("Largest Number: "+ maxNumber);
Console.WriteLine("Smallest Number: "+ minNumber);