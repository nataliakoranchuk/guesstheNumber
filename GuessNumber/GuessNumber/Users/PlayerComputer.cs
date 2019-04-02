using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class PlayerComputer : BasePlayer
    {
        
        //  Просто генерирует компъютерного игрока с опеределенными данными дефолтный конструктор
        public PlayerComputer():base(new Random(+1))
        {
            level = 1;
        }

        public override void sayIamHere()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("and I");
            Console.WriteLine("Start game!");
            Console.ResetColor();
        }

        public int GuessaNumber(int min, int max)
        {
            return r.Next(min, max);
        }
    }
}
