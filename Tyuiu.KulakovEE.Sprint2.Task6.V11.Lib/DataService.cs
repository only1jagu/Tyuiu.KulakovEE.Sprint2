﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KulakovEE.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            switch (n)
            {
                case 1:
                    switch (m)
                    {
                        case 1:
                            n = 31;
                            m = 12;
                            g--;
                            break;
                        default:
                            m--;
                            switch (m)
                            {
                                case 1:
                                case 3:
                                case 5:
                                case 7:
                                case 8:
                                case 10:
                                case 12:
                                    n = 31;
                                    break;
                                case 2:
                                    n = 28;
                                    break;
                                default:
                                    n = 30;
                                    break;
                            }
                            break;
                    }
                    break;
                default:
                    n++;
                    break;
            }
            string res = Convert.ToString(n + "." + m + "." + g);
            return res;
        }
    }
}

