// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint2.Task0.V17.Lib;

DataService ds = new DataService();

int x = 1065;
int y = 755;
bool[] res = new bool[6];
res = ds.GetCompareOperations(x, y);

Console.WriteLine("******************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                               *");
Console.WriteLine("******************************************************************");

Console.WriteLine("X = " + x);
Console.WriteLine("Y = " + y);

Console.WriteLine("******************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                     *");
Console.WriteLine("******************************************************************");

for (int i=0; i<6; i++)
{
    Console.WriteLine(res[i]);
}
Console.ReadKey();
