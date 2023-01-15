/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементом массива.*/

Console.Write("Введите любую цифру: ");
int n = int.Parse(Console.ReadLine());
int[] a = new int[] {444, 348, 610, 617, 1191, 211, 1205, 226, 26, 1226};
int max = a[0];
foreach (int x in a) if (x > max) max = x;
Console.WriteLine("max = " + max);
int min = a[0];
foreach (int x in a) if (x < min) min = x;
Console.WriteLine("min = " + min);
Console.WriteLine($"Разница между максимальным и минимальным элементом равна: {max-min}");
    