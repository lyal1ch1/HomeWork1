Console.WriteLine("Введите число от 1 до N :");
string num = Console.ReadLine()!;

double num1 = double.Parse(num);
Console.Clear();
if (num1 < 1)
{
 Console.WriteLine("Введите число больше 1 !!!");   
}
else
{
    Console.WriteLine("Ваши числа: ");
}
for (int i = 2; i <= num1; i+=2)
{
    Console.Write( i + " ");
}

