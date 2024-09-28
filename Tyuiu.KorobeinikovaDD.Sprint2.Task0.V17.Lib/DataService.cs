﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KorobeinikovaDD.Sprint2.Task0.V17.Lib
{
    public class DataService : ISprint2Task0V17
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x == y + 310;
            res[1] = x != y + 310;
            res[2] = x < y;
            res[3] = y > x;
            res[4] = x <= y;
            res[5] = y >= x;

            return res;

        }
    }
}
