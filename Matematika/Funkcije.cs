using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematika
{
    public static class Funkcije
    {
        public static long Faktorijel(int broj)
        {
            if (broj < 0)
                throw new ArgumentOutOfRangeException(nameof(broj));
            long rezultat = 1;
            for (int i = 2; i <= broj; ++i)
                rezultat *= i;
            return rezultat;
        }
    }
}
