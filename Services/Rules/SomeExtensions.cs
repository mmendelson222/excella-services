using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Services.Rules
{
    public static class SomeExtensions
    {
        public static int[] Primes(this int n)
        {
            var list = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) list.Add(i);
            }

            return list.ToArray();
        }

        public static void junk()
        {
            int i = 8;
            int[] fs = Primes(i);

        }
    }

  
}