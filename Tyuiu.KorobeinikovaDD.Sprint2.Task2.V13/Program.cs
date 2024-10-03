// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint2.Task2.V13.Lib;

DataService ds = new DataService();

Console.WriteLine("******************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                               *");
Console.WriteLine("******************************************************************");

Console.WriteLine("Введите значение переменной Х: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение переменной Y: ");
int y = Convert.ToInt32(Console.ReadLine());

bool res = ds.CheckDotInShadedArea(x, y);

Console.WriteLine("******************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                     *");
Console.WriteLine("******************************************************************");

if (res)
{
    Console.WriteLine("Точка находится в закрашенной области");
}
else
{
    Console.WriteLine("Точка не находится в закрашенной области");
}

Console.ReadKey();
