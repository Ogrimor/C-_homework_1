Console.WriteLine("Введите первое число: ");
string s1 = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string s2 = Console.ReadLine();
int firstNumber = int.Parse(s1);
int secondNumber = int.Parse(s2);
if ( firstNumber > secondNumber)
{
    Console.WriteLine("Первое число, больше второго");
}
else if (firstNumber < secondNumber)
{
    Console.WriteLine("Второе число, больше первого");
}
else
{
    Console.WriteLine("Числа равны");
}