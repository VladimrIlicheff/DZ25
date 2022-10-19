/* Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.WriteLine("Введите число 1");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 2");
int number2 = int.Parse(Console.ReadLine()!);
double degree = 0;
degree = Math.Pow(number1, number2);
Console.WriteLine($"итого {degree}");