using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Quest
{
    class Program
    {
      static player player;
        static void Main(string[] args)
        {
           player = new player();
            DataBase.load();
        menu:
            Console.Clear();
            Console.WriteLine("1: Играть");
            ConsoleKey  key = GetButton();
            Console.Clear();
            if (key == ConsoleKey.D1)
            {
                Console.WriteLine("Введите имя");
                player.name = Console.ReadLine();
                Game();
            }
            else
            {
                Console.WriteLine("Несуществующая команда");
                Thread.Sleep(2000);
                goto menu;
            }
        }
        public static void Game()
        {
            Console.Clear();
            Console.WriteLine("Вы просыпаетесь на дороге и ничего не помните, рядом стоит незнакомый бродяга.");
            Thread.Sleep(4000);
            bool talk= true;
        road:
            Console.Clear();
            Console.WriteLine("1: Информация 2: Инвентарь  /  Локация дорога:  3: Осмотреть окрестности  4: Поговорить с Бродягой");
            ConsoleKey key = GetButton();
            if (key == ConsoleKey.D1)
            {
                Console.Clear();
                player.info(player);
                Console.ReadKey();
                goto road;
            }
            else if (key == ConsoleKey.D2)
            {
                Console.Clear();
                player.inventory.GetAllItems();
                Console.WriteLine("Нажмите на любую клавишу");
                Console.ReadKey();
                goto road;
            }
            else if (key == ConsoleKey.D3)
            {
                Console.Clear();
                Console.WriteLine("Сейчас день, ясная погода, вы находитесь на пустой дороге, вокруг вас лес, справо от вас автобусная остановка, рядом с ней стоит незнакомый вам бродяга одетый в черный ободранный плащ. ");
                Console.WriteLine("Нажмите на любую клавишу");
                Console.ReadKey();
                goto road;
            }
            else if (key == ConsoleKey.D4)
            {
                Console.Clear();
                if (talk == true)
                {
                    Console.WriteLine("Как только вы пытаетесь заговорить с бродягой, он поворачивает голову к вам, не дав ничего вам сказать, и говорит:\nБродяга: Ты был избран.\nДалее он ротягивает свою руку и дает вам таинственный медальон и кучку монет\nПолучено:\n\n50 монет");
                    player.money += 50;
                    Console.WriteLine(DataBase.GetItem(1).name);
                    player.inventory.AddItem(new item("Медальон", 1, false));
                    talk =false;
                    Console.WriteLine("Нажмите на любую клавишу");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Бродяга больше ничего не говорит");
                    Thread.Sleep(2000);
                }
                goto road;
            }
            else
            {
                Console.WriteLine("Несуществующая команда");
                Thread.Sleep(2000);
                goto road;
            }
        }
        public static ConsoleKey GetButton()
        {
            var but = Console.ReadKey(true).Key;
                return but;
        }
    }

}
