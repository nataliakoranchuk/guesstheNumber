using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    static class AssignAttempts
    {
        // в зависимости от уровня человека мы назначаем ему количество попыток
        public static int CountAttempts(int level,int max,int min)
        {
            int attemps = 0;
            switch (level)
            {
                case 1:
                    if (max - min - 2 > 0) attemps = max - min - 2;
                    else attemps = 2;
                    break;
                case 2:
                    attemps = (max - min) / 2;
                    ++attemps;
                    break;
                default:
                    attemps = CalculateAttemptCount(max, min);
                    break;
            }
            return attemps;
        }
        private static int CalculateAttemptCount(int Max,int Min)
        {
            var length = Max - Min + 1;// we inclide number min and max
            var sum = 2;
            var power = 1;
            while (sum < length)
            {
                sum *= 2;
                power++;
            }

            return power;
        }
    }
}
