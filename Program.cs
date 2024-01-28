// Семинар 1. Знакомство с языками программирования
// Задание 1. Совместная работа
//Напишите программу, которая на вход принимает два целых числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// System.Console.WriteLine("Введите первое целое число");
// int num1 = Convert.ToInt32 (Console.ReadLine ());
// System.Console.WriteLine("Введите второе целое число");
// int num2 = Convert.ToInt32 (Console.ReadLine ());
// if (num2 * num2 == num1)
// {
//     System.Console.WriteLine("да");
// }
// else
//     System.Console.WriteLine("нет");

// Задание 2. Совместная работа
// Напишите программу, которая на вход принимает целое число N, 
// а на выходе показывает все целые числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

System.Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int i = - num;
while (i < num)
{
    Console.Write (i + ", ");
    i = i+1;
}
Console.WriteLine(i);