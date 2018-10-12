using System;
using System.Collections.Generic;
using System.Text;

namespace Shizukanawa.BasicMathLib
{
    public class isPrime
    {
        public static bool Check(int checkNumber)
        {
            if (checkNumber <= 1) return false;
            else if (checkNumber <= 3) return true;
            if (checkNumber % 2 == 0 || checkNumber % 3 == 0) return false;

            for (int i = 5; i * i <= checkNumber; i = i + 6)
            {
                if (checkNumber % i == 0 || checkNumber % (i + 2) == 0) return false;
            }

            return true;
        }
    }
}
