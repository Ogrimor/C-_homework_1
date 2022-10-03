Console.WriteLine("Введите первое число: ");
string s1 = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string s2 = Console.ReadLine();
Console.WriteLine("Введите третье число: ");
string s3 = Console.ReadLine();
int firstNumber = int.Parse(s1);
int secondNumber = int.Parse(s2);
int lastNumber = int.Parse(s3);
int max = firstNumber;
if (max < secondNumber)
{
    max = secondNumber;
}
else if(max < lastNumber)
{
    max = lastNumber;
}
Console.WriteLine("Вычисляем...");
Console.WriteLine("Наибольшее число: " + max);