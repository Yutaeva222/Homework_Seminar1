// Является ли число четным.
Console.Clear();
Console.WriteLine("Введите любое число: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a % 2 == 0)
{
    Console.WriteLine($"{a} это четное число.");
}
else
{
    Console.WriteLine($"{a} это НЕчетное число.");
}
