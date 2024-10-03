// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint2.Task1.V22.Lib;

DataService ds = new DataService();

var a = 324;
var b = 696;
var c = 254;
var d = 155;
bool[] res = new bool[6];
res = ds.GetLogicOperations(a, b, c, d);

Console.WriteLine("******************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                               *");
Console.WriteLine("******************************************************************");

Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.WriteLine("c = " + c);
Console.WriteLine("d = " + d);

Console.WriteLine("******************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                     *");
Console.WriteLine("******************************************************************");

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}
Console.ReadKey(); 

