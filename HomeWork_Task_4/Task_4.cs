Console.Clear();

Console.Write("Введите первое число: ");
double firstValue = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число: ");
double secondValue = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите третье число: ");
double thirdValue = Convert.ToDouble(Console.ReadLine());

double max = firstValue;

if (firstValue > max) max = firstValue;
if (secondValue > max) max = secondValue;
if (thirdValue > max) max = thirdValue;

Console.WriteLine("Наибольшее число будет: " + max);

