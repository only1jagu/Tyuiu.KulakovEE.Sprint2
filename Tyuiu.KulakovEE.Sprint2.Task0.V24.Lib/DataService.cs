using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KulakovEE.Sprint2.Task0.V24.Lib
{
    public class DataService : ISprint2Task0V24
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = y == x + 620;
            res[1] = x != y;
            res[2] = y > x + 777;
            res[3] = x > y;
            res[4] = x <= y;
            res[5] = y <=x + 623;
            return res;
        }
    }
}
