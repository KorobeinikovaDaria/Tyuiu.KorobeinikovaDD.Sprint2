// See https://aka.ms/new-console-template for more information
using Tyuiu.KorobeinikovaDD.Sprint2.Task6.V9.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнила: Коробейникова Д.Д. | ПКТб-24-1";
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* Тема: Получение результата из switch                                        *");
Console.WriteLine("* Задание #6                                                                  *");
Console.WriteLine("* Вариант #9                                                                  *");
Console.WriteLine("* Выполнила: Коробейникова Дарья Денисовна | ПКТб-24-1                        *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                    *");
Console.WriteLine("* Написать программу на С#, которая использует сокращенную форму записи       *");
Console.WriteLine("* оператора switch и вычисляет требуемое значение                             *");
Console.WriteLine("*                                                                             *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
Console.WriteLine("*******************************************************************************");
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

Console.WriteLine("*******************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
Console.WriteLine("*******************************************************************************");
Console.WriteLine(t);

Console.ReadKey();
