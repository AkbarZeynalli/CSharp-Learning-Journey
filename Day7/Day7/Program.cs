#region between 1 and 3:

//string message;

//Start: 
//Console.Write("Enter a number between 1 and 3: ");
//if (!int.TryParse(Console.ReadLine(),out int number))
//{
//    Console.WriteLine("Invalid Input, Please Enter a numeric value!");
//    return;
//}
//switch (number)
//{
//    case 1:
//        message = "You Selected one";
//        break;
//    case 2:
//        message = "You selected two";
//        break;
//    case 3:
//        message = "You Selected Three";
//        break;
//    default:
//        message = "Invalid Selection. Please enter a number between 1 and 3";
//        Console.WriteLine(message);
//        goto Start;
//}
//Console.WriteLine(message);

#endregion


#region letter between A and C 
string message;

Console.Write("Enter Letter: ");
if (!char.TryParse(Console.ReadLine(), out char letter))
{
    Console.WriteLine("Invalid Input!");
    return;
}

switch (letter)
{
    case 'a':
    case 'A':
        Console.WriteLine("You Entered A");
        break;
    case 'b':
    case 'B':
        Console.WriteLine("You Entered B");
        break;
    case 'c':
    case 'C':
        Console.WriteLine("You Enterd C");
        break;
    default:
        Console.WriteLine("Different letter");
        break;
#endregion
}