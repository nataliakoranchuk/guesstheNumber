using GuessNumber.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {

        static void Main(string[] args)
        {
            Game g = new Game();
            g.Start_Game();
        }
    }
}
