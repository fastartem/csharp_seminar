Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine()??"0");
Console.WriteLine((num % 2 == 0) ? "Yes" : "No");