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
            if (broj == 0)
                return 1;
            long rezultat = broj;
            while (--broj > 1)
                rezultat *= broj;
            return rezultat;
        }
    }
}
