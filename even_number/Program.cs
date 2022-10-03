Console.WriteLine("Введите число: ");
string s1 = Console.ReadLine();
int number = int.Parse(s1);
if (number%2 == 0)
{
    Console.WriteLine("Введённое Вами число, является чётным");
}
else
{
    Console.WriteLine("Введённое Вами число не является чётным");
}