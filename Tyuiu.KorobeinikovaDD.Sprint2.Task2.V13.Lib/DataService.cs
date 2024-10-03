using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KorobeinikovaDD.Sprint2.Task2.V13.Lib
{
    public class DataService : ISprint2Task2V13
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            var z = (x == 4) && (y >= 2) && (y <= 8);
            var e = (y == 6) && (x >= 3) && (x <= 7);
            var t = (y >= 5) && (y <= 10) && (x >= 8) && (x <= 12);
            var w = (y > 2) && (y <= 4) && (x >= 9) && (x <= 12);
            var f = (x == 13) && (y >= 6) && (y <= 9);
            var s = (y >= 11) && (y <= 12) && (x >= 7) && (x <= 9);
            var m = (y == 10) && (x > +6) && (x <= 7);
            var n = (y == 11) && (x >= 3) && (x <= 6);
            if ((z)||(e)||(t)||(w)||(f)||(s)|(m)||(n))
            { return true; }
            else { return false; }
        }
    }
}
