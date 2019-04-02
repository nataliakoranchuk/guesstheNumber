using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Player:BasePlayer
    {      
        public string password { get; set; }

        // Просто генерирует человеческого игрока с опеределенными данными дефолтный конструктор
        public Player() : base(new Random())
        {
   
            level = 1;
            Id = 1;
        }

        
  
    }
}
