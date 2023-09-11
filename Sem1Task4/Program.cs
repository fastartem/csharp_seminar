Console.Write("Enter first number: ");
int firstNum = int.Parse(Console.ReadLine()??"0");
Console.Write("Enter second number: ");
int secondNum = int.Parse(Console.ReadLine()??"0");
Console.Write("Enter third number: ");
int thirdNum = int.Parse(Console.ReadLine()??"0");

int max = firstNum;
if(secondNum > max){
    max = secondNum;
}
if(thirdNum > max){
    max = thirdNum;
}

Console.WriteLine("Max is " + max);