Console.Clear();
Console.Write("Введите первое число: ");
double firstValue = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double secondValue = Convert.ToDouble(Console.ReadLine());
if (firstValue > secondValue)
{
    Console.WriteLine("Число " + firstValue + " больше чем " + secondValue);
}
else
{
    Console.WriteLine("Число " + secondValue + " больше чем " + firstValue);
}
