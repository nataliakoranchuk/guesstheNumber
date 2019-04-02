using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
     abstract class BasePlayer
    {
        public Random r = new Random();

        public int Id { get; set; }
        public int Score { get; set; } = 0;
        public int level { get; set; } = 1;
        public string Name { get; set; }
        public int Age { get; set; }

        internal BasePlayer(Random r)
        {
            Name = GenName(r);
            Age = GenAge(r);
            AboutMe();
            sayIamHere();
        }
        // Выбирает имя
        public string GenName(Random r)
        {
            int d = r.Next(0, 14);
            return Enum.GetName(typeof(Name), d);
        }

        // Выбирает возраст
        public int GenAge(Random r)
        {
            return r.Next(7, 60);
        }
        public virtual void sayIamHere()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("I'm here");
            Console.ResetColor();
        }
        public void AboutMe()
        {
            Console.WriteLine($"My name's {Name}. I'm {Age} years old.");
        }
    }
}
