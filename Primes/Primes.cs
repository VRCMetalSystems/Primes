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
            // Default empty list
            var result = new List<int>();
            for (int n = 0; n <= N; n++)
            {
                if(IsPrime(n))
                    result.Add(n);
            }
            return result;
        }

        public static bool IsPrime(int N)
        {
            // Negative Numbers, 0, 1, and evens are instantly out
            if (N < 2) return false;
            if (N < 4) return true;
            if (IsEven(N)) return false; // Have to check this after we move past 2
            for(int n = 3; n <= N; n+= 2)
            {
                if (IsDivisor(N, n)) return false;
            }

            return true;
        }

        public static bool IsEven(int N)
        {
            return (N % 2 == 0);
        }

        public static bool IsDivisor(int N, int n)
        {
            return (N % n == 0);
        }
    }
}
