using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes
{
    public static class Primes
    {
        public static List<int> FindPrimes(int N)
        {
            var result = new List<int>();
            if (N < 2)
                return result;
            if (N == 2)
                result.Add(N);

            return result;
        }
    }
}
