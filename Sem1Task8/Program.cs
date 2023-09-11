Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine()??"0");

for(int i = 2; i < num; i++){
    if(i % 2 == 0){
        Console.Write(i + ", ");
    }
}

if(num % 2 == 0){
    Console.Write(num);
}
