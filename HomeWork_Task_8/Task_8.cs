Console.Clear();

Console.Write("Введите любое число: ");
double N = Convert.ToDouble(Console.ReadLine());
double count = 0;
while (N > count)
{
    count = count + 2;
    Console.WriteLine(count);
}