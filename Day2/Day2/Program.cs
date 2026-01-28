using System.Globalization;

//Convert vs (int) fərqi 



//double num = 2.7;
//int num2 = (int)num;

//int num3 = Convert.ToInt32(num);

//Console.WriteLine(num3); 

//null convert
//Console.WriteLine(Convert.ToInt32(false));
//Console.WriteLine(Convert.ToInt32(true));
//Console.WriteLine(Convert.ToInt32(null));

//Tapşırıq 1 — Variable + Type Conversion + Riyaziyyat
/*
Console.WriteLine("int tipdinə ədəd daxil et: ");
short numberInt = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("double tipdinə ədəd daxil et: ");
double numberDouble = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("string tipdinə ədəd daxil et: ");
string numberString = Convert.ToString(Console.ReadLine());

double convertedStringNumber = Convert.ToDouble(numberString);
double result = (numberInt*numberDouble)/convertedStringNumber;
*/


//Tapşırıq 2 — Memory və Variable Davranışı
/*
int a = 5;
int b = a;
b += 10;

int c = b;
a = c - b;

Console.WriteLine($"a={a}, b={b}, c={c}");//a=0,b=15,c=15
*/


//Tapşırıq 3 — Checked vs Unchecked

//int x = int.MaxValue;
//int y = 1;

//int result1 = unchecked(x + y);
//int result2 = checked(x + y);

//Console.WriteLine(result1);
//Console.WriteLine(result2);


//Tapşırıq 4 — Scope + Shadowing
//int number = 20;

//{
//    int number2 = number + 10;
//    number = number2 * 2;
//}

//{
//    int number = 5;
//    number += 3;
//    Console.WriteLine(number);
//}

//Console.WriteLine(number);



//Tapşırıq 5 — Dəyişənlərlə Mini Kalkulyator (amma hiyləli) Nəticə = 4.5
/*
int a = 8;
int b = 3;
double c = 2;

a = a + b;
c = (a - c) / c;
Console.WriteLine(c);
*/