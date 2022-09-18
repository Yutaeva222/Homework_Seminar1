Console.Clear();
Console.WriteLine("Введите любое число: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a % 2 == 0)
{
    Console.WriteLine("Это четное число. ");
}
else
{
    Console.WriteLine("Это нечетное число.");
}
