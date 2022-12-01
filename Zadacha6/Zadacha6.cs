Console.WriteLine("Введите первое число:");
string num = Console.ReadLine()!;
double num1 = double.Parse(num);

if (num1 % 2 == 0)
{
 Console.WriteLine (num1 +"- четное число!");

}

else
{
Console.WriteLine (num1 +"- не четное число!");
    
}