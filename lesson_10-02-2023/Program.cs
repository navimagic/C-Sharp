//Console.Clear();
//Console.Write("Введите любое число: ");
//double number = Convert.ToDouble(Console.ReadLine());
//double result = number * number;
//Console.WriteLine("Квадрат от числа: " + number + " равен " + result);




// Console.Clear();
// Console.Write("Введите первое число: ");
// int firstValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int secondValue = Convert.ToInt32(Console.ReadLine());
// if (firstValue == Math.Pow(secondValue, 2))
//{
//    Console.WriteLine("Число " + firstValue + " является квадратом от " + secondValue);
//}
//else
//{
//    Console.WriteLine("Число " + firstValue + " не является квадратом от " + secondValue);
//}
// 


Console.Clear();
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 0)
{
    N = N * (-1);
}
int negativeN = N * (-1);
while (negativeN <= N)
{
    Console.WriteLine(negativeN);
    negativeN++;
}