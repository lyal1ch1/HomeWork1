Console.WriteLine("Введите первое число:");
string number1 = Console.ReadLine()!;

Console.WriteLine("Введите второе число:");
string number2 = Console.ReadLine()!;

Console.WriteLine("Введите третье число:");
string number3 = Console.ReadLine()!;

double Number_1 = double.Parse(number1);
double Number_2 = double.Parse(number2);
double Number_3 = double.Parse(number3);

if (Number_1 > Number_2)
{
    if (Number_1 > Number_3)
    {
        Console.WriteLine("Max=" + Number_1);
    }
}

if (Number_2 > Number_3)
{
    if (Number_2 > Number_1)
    {
        Console.WriteLine("Max=" + Number_2);
    }
}

if (Number_3 > Number_2)
{
    if (Number_3 > Number_1)
    {
        Console.WriteLine("Max=" + Number_3);
    }
}


if (Number_1 == Number_2 )
{
    if (Number_2 == Number_3 )
    Console.WriteLine("Числа равны");
}
