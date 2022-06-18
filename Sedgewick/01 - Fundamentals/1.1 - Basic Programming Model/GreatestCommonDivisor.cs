using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1___Basic_Programming_Model
{
    class GreatestCommonDivisor
    {
        public static int GCD(int p, int q)
        {
            if (q == 0) return p;
            int r = p % q;
            return GCD(q, r);
        }
    }
}

//Compute the greatest common divisor of
//two nonnegative integers p and q as follows:
//If q is 0, the answer is p. If not, divide p by q
//and take the remainder r. The answer is the
//greatest common divisor of q and r.