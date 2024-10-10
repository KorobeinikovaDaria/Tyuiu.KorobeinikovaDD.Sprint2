// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint2.Task7.V14.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнила: Коробейникова Д.Д. | ПКТб-24-1";
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов                                *");
Console.WriteLine("* Задание #7                                                                  *");
Console.WriteLine("* Вариант #14                                                                 *");
Console.WriteLine("* Выполнила: Коробейникова Дарья Денисовна | ПКТб-24-1                        *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                    *");
Console.WriteLine("* Написать программу на С#, которая запрашивает исходные данные и вычисляет,  *");
Console.WriteLine("* находится ли точка с координатами X,Y в заштрихованной области              *");
Console.WriteLine("*                                                                             *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
Console.WriteLine("*******************************************************************************");

Console.WriteLine("Введите значение переменной X: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение переменной Y: ");
double y = Convert.ToDouble(Console.ReadLine());

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

