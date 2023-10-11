using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KulakovEE.Sprint2.Task1.V6.Lib
{
    public class DataService : ISprint2Task1V6
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (b > a) | (c == d);
            res[1] = (a == d) & (b > c);
            res[2] = (c >= d) || (a == b + 746);
            res[3] = (a <= c) && (b != d);
            res[4] = !(a < c);
            res[5] = (b + 5 == c) ^ (a != d);

            return res;
        }
    }
}
