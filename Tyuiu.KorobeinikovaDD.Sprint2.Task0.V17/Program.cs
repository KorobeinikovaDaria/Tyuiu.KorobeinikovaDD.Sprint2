// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint2.Task0.V17.Lib;

DataService ds = new DataService();

int x = 1065;
int y = 755;
bool[] res = new bool[6];
res = ds.GetCompareOperations(x, y);

Console.Title = "Спринт #2 | Выполнила: Коробейникова Д.Д. | ПКТб-24-1";
Console.WriteLine("********************************************************************************");
Console.WriteLine("* Тема: Получение результата из switch                                         *");
Console.WriteLine("* Задание #0                                                                   *");
Console.WriteLine("* Вариант #22                                                                  *");
Console.WriteLine("* Выполнила: Коробейникова Дарья Денисовна | ПКТб-24-1                         *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                     *");
Console.WriteLine("* Написать программу на С# из операций сравнения и арифметических выражений,   *");
Console.WriteLine("* которая вернёт логическую последовательность                                 *");
Console.WriteLine("*                                                                              *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
Console.WriteLine("********************************************************************************");

Console.WriteLine("X = " + x);
Console.WriteLine("Y = " + y);

Console.WriteLine("********************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
Console.WriteLine("********************************************************************************");

for (int i=0; i<6; i++)
{
    Console.WriteLine(res[i]);
}
Console.ReadKey();
