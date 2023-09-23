﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double k1 = WorkWithUser("Введите значение k1: ");
double k2 = WorkWithUser("Введите значение k2: ");
double b1 = WorkWithUser("Введите значение b1: ");
double b2 = WorkWithUser("Введите значение b2: ");
double[] res = Resolve(k1, b1, k2, b2);
Console.WriteLine(string.Join(", ", res));

double WorkWithUser(string msg)
{
    Console.WriteLine(msg);
    double number = double.Parse(Console.ReadLine());
    return number;
}

double[] Resolve(double k1, double b1, double k2, double b2)
{
    double[] resolve = new double[2];
    resolve[0] = (b2 - b1) / (k1 - k2);
    resolve[1] = k1 * resolve[0] + b1;
    return resolve;
}