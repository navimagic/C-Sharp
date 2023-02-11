Console.Clear();

Console.Write("Введите любое число: ");
double number = Convert.ToDouble(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Введенное вами число является четным")
;}
if (number % 2 == 1)
{
    Console.WriteLine("Введенное вами число НЕ является четным");
}