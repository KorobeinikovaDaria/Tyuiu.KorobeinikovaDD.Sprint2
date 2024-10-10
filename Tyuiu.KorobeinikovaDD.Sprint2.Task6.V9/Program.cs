﻿// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint2.Task6.V9.Lib;
DataService ds = new DataService();

Console.WriteLine("******************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                               *");
Console.WriteLine("******************************************************************");

Console.WriteLine("Введите значение переменной m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение переменной n: ");
int n = Convert.ToInt32(Console.ReadLine());

string t;

if ((m < 1) || (m > 12) || (n < 1) || (n > 31))
{
    t = "Введенно неверное значение!";
}
else
{
    t = "Дата следующего дня: " + ds.FindDateOfNextDay(m, n);
}

Console.WriteLine("******************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                     *");
Console.WriteLine("******************************************************************");
Console.WriteLine(t);

Console.ReadKey();
