Console.Clear();
Console.WriteLine("Введите любое число: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a % 2 == 1)
{
    Console.WriteLine("Это нечетное число. ");
}
else
{
    Console.WriteLine("Это число четное.");
}
