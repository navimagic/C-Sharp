Console.Clear();

Console.Write("Введите любое число: ");
double number = Convert.ToDouble(Console.ReadLine());
double result = number * number;
Console.WriteLine("Квадрат от числа: " + number + " равен " + result);