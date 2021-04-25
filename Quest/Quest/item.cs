using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest
{
    class item : ICloneable
    {
        public string name;
        public int id;
        public bool isStack;
        public int count;
        public item(string name, int id, bool isStack, int count = 1)
        {
            this.name = name;
            this.id = id;
            this.isStack = isStack;
            this.count = count;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
