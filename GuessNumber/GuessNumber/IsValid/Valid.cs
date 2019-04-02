using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber.IsValid
{
    static class Valid
    {
        //проверка на число , либо null
        public static int? IsNumber(string num)
        {
            try { return int.Parse(num); }
            catch (FormatException) { return null; }
        }

        public static bool MinAndMax(int min, int max)
        {
            if (min > max) return false;
            return true;
        }

    }
}
