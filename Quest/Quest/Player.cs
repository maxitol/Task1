using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest
{
    class player
    {
        public string name;
        public int health, healthMax;
        public int money;
        public int power, powerMax;
        public inventory inventory;

        public player()
        {
            inventory = new inventory();
            powerMax = 50;
            healthMax = 100;
            health = healthMax;
            power = powerMax;
            money = 0;
        }
        public void info(player player)
        {
            Console.WriteLine($"Имя: {player.name}");
            Console.WriteLine($"Здоровье: {player.health}/{player.healthMax}");
            Console.WriteLine($"Энергия: {player.power}/{player.powerMax}");
            Console.WriteLine($"Монеты {player.money}");
            Console.WriteLine("Нажмите на любую клавишу");
        }
    }
    class inventory
    {
        public List<item> items = new List<item>();

        public void AddItem(item item)
        {
            if (items.Count > 0)
                for (int i = 0; i < items.Count; i++)
                {
                    if (item.id == items[i].id && items[i].isStack)
                    {
                        items[i].count += item.count;
                        break;
                    }
                    else if (i == items.Count - 1)
                    {
                        items.Add(item);
                        break;
                    }
                }
            else
                items.Add(item);
        }

        public void GetAllItems()
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i}: {items[i].name} X {items[i].count}");
            }
        }
    }
}
