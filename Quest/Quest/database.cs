using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest
{
    static class DataBase
    {
        public static List<item> items;

        public static void load()
        {
            items = new List<item>();
            items.Add(new item("Медальон", 1, false));
        }

        public static item GetItem(int id, int count = 1)
        {
            item item = (item)items.Find(I => I.id == id).Clone();

            if (item != null)
            {
                if (item.isStack)
                    item.count = count;
                else
                    item.count = 1;
                return item;
            }
            else
            {
                return null;
            }
        }
    }
}
