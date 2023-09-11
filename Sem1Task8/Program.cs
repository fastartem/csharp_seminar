Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine()??"0");
string numbers = "";

for(int i = 2; i <= num; i++){
    if(i % 2 == 0){
        numbers = string.Concat(numbers, i + ", ");
    }
}
numbers = numbers.TrimEnd(' ');
numbers = numbers.TrimEnd(',');

Console.Write(numbers);