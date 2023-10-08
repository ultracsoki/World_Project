using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_Project
{
    internal class Herbivore : Creature
    {
        private int size;
        public Herbivore(int size, int sight) : base(sight)
        {
            sight = 1;
            this.size = size;
            if (this.size <= 0)
            {
                throw new ArgumentException("A növényevő méretének pozitívnak kell lennie.", nameof(this.size));
            }
        }

        public int GetSize()
        {
            return this.size;
        }
    }
}
