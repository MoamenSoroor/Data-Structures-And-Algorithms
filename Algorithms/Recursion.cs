﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Recursion
    {

        public static int Factorial( int n)
        {
            if (n == 0) return 1;
            else return n * Factorial(n - 1);
        }




        public static void Test()
        {

        }



    }
}
