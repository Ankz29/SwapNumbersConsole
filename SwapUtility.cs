using System;
using System.Collections.Generic;
using System.Text;

namespace SwapNumbersConsole
{
   public static class SwapUtility
    {
        static int tempVariable = 0;
        public static string SwapNumbers(int a , int b)
        {
            tempVariable = a;
            a = b;
            b = tempVariable;

            return "Value 1 contains: "+ a +"\n"+ " Value 2 contains: " + b;

        }
    }
}
