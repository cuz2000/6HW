﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Введите число k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1)/(k1 - k2);

Console.WriteLine($"Точка пересечения: {x},{k1*x + b1}");