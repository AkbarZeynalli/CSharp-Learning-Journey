//Nulable type value type refernce type
using System.Globalization;


//int[] a = [1, 2, 3];
//int[] b = a;
//b[0] = 18;
//Console.WriteLine(a);
//Console.WriteLine(b);


//string n1 = "Salam";
//string n2 = n1;
//n2 = "Hello";
//Console.WriteLine(n1);
//Console.WriteLine(n2);


//int? nameNull = null;
//Console.WriteLine(nameNull.GetValueOrDefault());


//int? number  = null;
//int y = number ?? 18;
//Console.WriteLine(number);
//Console.WriteLine(y);


#region nullable
//int? number = null;

//int reslut1 = number ?? 0;
//int reslut2 = number.GetValueOrDefault();
//int reslut3 = Convert.ToInt32(number);

//Console.WriteLine(reslut1);
//Console.WriteLine(reslut2);
//Console.WriteLine(reslut3);
#endregion

#region SipmleNullable
Console.WriteLine("Please Enter your age: ");
string? input = Console.ReadLine();

int? age = null;

if (input != "")
{
    age = Convert.ToInt32(input);
}
int? result = age ?? 0;
Console.WriteLine(result);
#endregion