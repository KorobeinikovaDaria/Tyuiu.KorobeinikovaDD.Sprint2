using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KorobeinikovaDD.Sprint2.Task3.V18.Lib
{
    public class DataService : ISprint2Task3V18
    {
        public double Calculate(double x)
        {
            double y = 0;
            var t = Math.Pow(x, 2);
            if (x > 1) { y = t * Math.Pow((x + 1) / (x - 1), x); }
            else
            {
                if (x == 0) { y = (t - Math.Cos(t) + 10) / (t - Math.Sin(t) + 12);}
                else
                {
                    if (( x > -22)&&( x < 2)) {y =  Math.Pow((1 + (1 / t)), x); }
                    else
                    {
                        if (x < -22) { y = x + 10 * x - (1 / x); }
                    }
                }
         
            }
            return Math.Round(y, 3);
            
        }
    }
}
