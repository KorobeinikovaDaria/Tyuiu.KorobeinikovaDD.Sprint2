using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KorobeinikovaDD.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            var res = "";
            var res1 = "";

            switch (n)
            {
                case (1):
                    if ((m == 2) | (m == 4) | (m == 11) | (m == 9) | (m == 8) | (m == 6)|(m == 1)) { res = "31"; m -= 1; }
                    else
                    {
                        if (m == 3) { res = "28"; m = 2; }
                        else { res = "30"; m -= 1; }
                    }
                    break;
                case 2:
                    res = "01";
                    break;
                case 3:
                    res = "02";
                    break;
                case 4:
                    res = "03";
                    break;
                case 5:
                    res = "04";
                    break;
                case 6:
                    res = "05";
                    break;
                case 7:
                    res = "06";
                    break;
                case 8:
                    res = "07";
                    break;
                case 9:
                    res = "08";
                    break;
                case 10:
                    res = "09";
                    break;
                case 11:
                    res = "10";
                    break;
                case 12:
                    res = "11";
                    break;
                case 13:
                    res = "12";
                    break;
                case 14:
                    res = "13";
                    break;
                case 15:
                    res = "14";
                    break;
                case 16:
                    res = "15";

                    break;
                case 17:
                    res = "16";
                    break;
                case 18:
                    res = "17";
                    break;
                case 19:
                    res = "18";
                    break;
                case 20:
                    res = "19";
                    break;
                case 21:
                    res = "20";
                    break;
                case 22:
                    res = "21";
                    break;
                case 23:
                    res = "22";
                    break;
                case 24:
                    res = "23";
                    break;
                case 25:
                    res = "24";
                    break;
                case 26:
                    res = "25";
                    break;
                case 27:
                    res = "26";
                    break;
                case 28:
                    res = "27";
                    break;
                case 29:
                    res = "28";
                    break;
                case 30:
                    res = "29";
                    break;
                case 31:
                    res = "30";
                    break;
                default:
                    throw new ArgumentException($"Значение n должно быть от 1 до 31.");
              
            }
            switch (m)
            {
                case (1):
                    res1 = "01";
                    break;
                case 2:
                    res1 = "02";
                    break;
                case 3:
                    res1 = "03";
                    break;
                case 4:
                    res1 = "04";
                    break;
                case 5:
                    res1 = "05";
                    break;
                case 6:
                    res1 = "06";
                    break;
                case 7:
                    res1 = "07";
                    break;
                case 8:
                    res1 = "08";
                    break;
                case 9:
                    res1 = "09";
                    break;
                case 10:
                    res1 = "10";
                    break;
                case 11:
                    res1 = "11";
                    break;
                case 12:
                    res1 = "12";
                    break;
                default:
                    throw new ArgumentException($"Значение m должно быть от 1 до 12.");
                        }
            
            return res + "." + res1;
        }
    }
}
