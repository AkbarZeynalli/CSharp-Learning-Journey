//Axıllı İdman Salonu Qeydiyyatı üçün məlumat sistemi

const decimal MonthlyMemberShipFee = 2000m;
const int MonthlyInYear = 12;

Console.Write("Enter First Name: ");
string? memberFirstName = Console.ReadLine();

Console.Write("Enter Last Name: ");
string? memberLastName = Console.ReadLine();

Console.Write("Enter Gender(M/F): ");
char? memberGender = char.Parse(Console.ReadLine());

Console.Write("is student (true/false): ");
bool? isStudent = bool.Parse(Console.ReadLine());

Console.Write("Heigh (meters): ");
double memberHeigh = double.Parse(Console.ReadLine());

Console.Write("Weigh (kg): ");
double memberWeigh = double.Parse(Console.ReadLine());

Console.Write("MemberShip Id: ");
int? memberShipId = int.Parse(Console.ReadLine());

Console.Write("MemberShip Type: ");
string? memberShipType = Console.ReadLine();

decimal yearlyCost = MonthlyMemberShipFee * MonthlyInYear;

double bodyMassIndex = memberWeigh / (memberHeigh * memberHeigh);

Console.WriteLine();
Console.WriteLine("___GYM MEMBER INFORMATION___");
Console.WriteLine("Member ID: " + memberShipId);
Console.WriteLine("Full Name: "+memberFirstName +" "+memberLastName);
Console.WriteLine("Gender: " + memberGender);
Console.WriteLine("Student Status: " + isStudent);
Console.WriteLine("MemberShipType: "+memberShipType);
Console.WriteLine("Monthly Fee: " + MonthlyMemberShipFee + "AZN");
Console.WriteLine("Yearly Cost: "+yearlyCost +"AZN");
Console.WriteLine("Height (m): " + memberHeigh);
Console.WriteLine("Weight (kg): " + memberWeigh);
Console.WriteLine("BMI: " + bodyMassIndex);
Console.WriteLine("_______________________________________________");