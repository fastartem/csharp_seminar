Console.Write("Enter first number: ");
int firstNum = int.Parse(Console.ReadLine()??"0");
Console.Write("Enter second number: ");
int secondNum = int.Parse(Console.ReadLine()??"0");
if (firstNum > secondNum){
    Console.WriteLine("First number > second number");
}
else if (firstNum < secondNum){
     Console.WriteLine("Second number > first number");
}
else {
     Console.WriteLine("Numbers are equal");
}