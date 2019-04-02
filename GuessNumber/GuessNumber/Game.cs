using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber.Users
{
    class Game
    {
        private Player _player_1;
        private PlayerComputer _playerComputer;
        int min = 0, max = 0, guessNumber = 0, attempts;
        public Game(Player player_1, PlayerComputer playerComputer)
        {
            _player_1 = player_1;
            _playerComputer = playerComputer;
        }

        // если это первая игра.
        public Game()
        {
            _player_1 = new Player();
            _playerComputer = new PlayerComputer();
        
        }
        public void Start_Game()
        {
            have_interval_haveHumber();
            // Получаем количество попыток, которое зависит от уровня человека
            attempts = AssignAttempts.CountAttempts(_player_1.level, max, min);
            // пока положу это здесь. Убрать в метод. Продумать систему начисления очков
            if (Try_to_guess_the_number())
            {
                Console.WriteLine("Победа!!!!!");
                _player_1.level++;
                _player_1.Score += 5;
            }
            else Console.WriteLine("Вы проиграли!!");
            Console.Read();

        }
        private void have_interval_haveHumber()
        {
            //получаем промежуток
            GetMinAndMax(ref min,ref max);
            Console.WriteLine($"Итого от{min}до{max} ваш промежуток");
            // загадывает число
            guessNumber = _playerComputer.GuessaNumber(min, max);
        }

        //Получить валидное число
        private int HumanSayaNumber()
        {
            Console.WriteLine("Введите валидное число");
            var line = Console.ReadLine();
            int? num = IsValid.Valid.IsNumber(line);
            while (num == null)
            {
                Console.WriteLine("Это не число! Буду спрашивать пока не введете число");
                line = Console.ReadLine();
                num = IsValid.Valid.IsNumber(line);
            }
            Console.WriteLine("Число валидно");
            return (int)num;
        }

        private void GetMinAndMax(ref int min, ref int max)
        {
            Console.WriteLine("Введите сначала минальное потом максимальное число");
            Console.WriteLine("У вас есть 3 попытки ввести правильно, после 3-х попыток");
            Console.WriteLine("Я выберу из чисел максимальное и минимальное сам");
            int count = 0;
            bool label = false;

            while (count < 3)
            {
                min = HumanSayaNumber();
                max = HumanSayaNumber();
                label =IsValid.Valid.MinAndMax(min, max);
                count++;
                if (label) break;
                else Console.WriteLine("Вы ввели не правильно! Сначала минимальное вводиться, потом максимальное");
            }
            //если человек так и не ввел правильно помогаем ему
            if (!label)
            {
                int swap = max;
                max = min;
                min = swap;

            }
            Console.Clear();
        }

        // происходит угадывание числа
        private bool Try_to_guess_the_number()
        {
            Console.WriteLine("Угадывайте число");
            int number; bool label =false;
            while (attempts != 0)
            {
                number = HumanSayaNumber();
                if (guessNumber < number) Console.WriteLine($"{number}> загаднное");
                else if (guessNumber > number) Console.WriteLine($" {number}<загаданное");
                else if (guessNumber == number) { label = true; break; }
                --attempts;    
            }
            return label;


        }


    }
}
