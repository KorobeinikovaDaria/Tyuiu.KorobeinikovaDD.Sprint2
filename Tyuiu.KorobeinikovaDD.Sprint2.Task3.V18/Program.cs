// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint2.Task3.V18.Lib;

DataService ds = new DataService();

Console.WriteLine("******************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                               *");
Console.WriteLine("******************************************************************");

Console.WriteLine("Введите значение переменной Х: ");
double x = Convert.ToDouble(Console.ReadLine());
double res = ds.Calculate(x);

Console.WriteLine("******************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                     *");
Console.WriteLine("******************************************************************");
Console.WriteLine("Значение функции - " + res);
 
Console.ReadKey();