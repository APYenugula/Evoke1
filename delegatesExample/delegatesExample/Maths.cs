using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace delegatesExample
{
    internal class Maths
    {
        public int add(int x, int y)
        {
            return x + y;
        }
        public int max(int x,int y)
        {
            if (x > y)
            {
                return x;
            }
            else if (x < y)
            {
                return y;
            }
            else
            {
                return -1;
            }
        }
        public int Sub(int x,int y)
        {
            return x - y;
        }
    }
}
