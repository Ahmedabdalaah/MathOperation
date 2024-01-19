using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperation
{
    internal class Calc
    {
        public int sum(int x , int y)
        {
            int result = x + y;
            return result;
        }    
        public int minus(int x, int y)
        {
            int result = x-y;
            return result;
        }
        public int mult(int x , int y)
        {
            int result = x * y;
            return result;
        }
        public int mod(int x, int y)
        {
            int result = x % y;
            return result;
        }
        public int min ( int x , int y)
        {
            if (x > y)
            {
                return y;
            }
            else
            {
                return x;
            }
        }
        public int max (int x , int y)
        {
            if (x >y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
        }
    
}
