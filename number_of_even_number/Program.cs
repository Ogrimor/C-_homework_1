Console.WriteLine("Введите число: ");
string s1 = Console.ReadLine();
int number = int.Parse(s1);
int i;
Console.WriteLine("Чётные числа, от 0 до " + number);
for (i = 0; i <= number; i++)
{
    if (i%2 == 0)
    {
        Console.WriteLine(i);
    }
}