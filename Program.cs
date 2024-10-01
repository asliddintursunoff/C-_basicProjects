// task 1

decimal PI = 3.14m;
System.Console.Write("Enter the radius: ");
string radi = Console.ReadLine();
decimal radius = Convert.ToDecimal(radi);
Console.WriteLine($"area equals to: {PI*radius*radius}");
Console.WriteLine($"length equals to: {PI*radius*2}");
Console.WriteLine("_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_");
//task 2 

System.Console.Write("Enter your sum of banknote(usd): ");
string valyuta = Console.ReadLine();
double kurs = Convert.ToDouble(valyuta);
System.Console.Write("Enter the rate of banknote(so'm): ");
string rate1 = Console.ReadLine();
double rate = Convert.ToDouble(rate1);
Console.WriteLine("Converted successfully...");
Console.WriteLine($"Your sum is {kurs}(usd)\nRate of So'm is {rate}\nYour wallet is {rate*kurs} so'm");
Console.WriteLine("_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*_");


//task 3 
Console.Write("Enter your birth year: ");
int year= Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine($"You have been living {(2024 - year)*365}");


