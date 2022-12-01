Console.WriteLine("Введите первое число:");
string number1 = Console.ReadLine()!;

Console.WriteLine("Введите второе число:");
string number2 = Console.ReadLine()!;

int Number_1 = int.Parse(number1);
int Number_2 = int.Parse(number2);

if (Number_1 > Number_2)
{
  Console.Write("Max=" + Number_1);  
  Console.WriteLine("Min=" + Number_2);
}

if (Number_1 < Number_2)
{
  Console.WriteLine("Max=" + Number_2);  
  Console.WriteLine("Min=" + Number_1);
}

 else
 {
    Console.WriteLine("Числа равны");
 }
