using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_Project
{
    internal class Cell
    {
        private List<Creature> creatures = new List<Creature>(); 
        private World world;
        private int x;
        private int y;
        private int plants;
        public static readonly int MAX_PLANTS = 100;
        public Cell(World w, int x, int y)
        {
            this.world = w;
            this.x = x;
            this.y = y;
            this.plants = 0;
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }

        public int GetPlants()
        {
            return plants;
        }

        public void ChangePlants(int amount)
        {
            int plant = (plants += amount);
            plants -= amount;
            if ((plant) < 0)
            {
                throw new ArgumentException("A növények értéke kevesebb mint 0 lett.",nameof(plants));
            }
            else if((plant) > MAX_PLANTS)
            {
                plants = MAX_PLANTS;
            }
            else
            {
                plants += amount;
            }
        }

        public void AddCreature(Creature c)
        {
            creatures.Add(c);
        }

        public void RemoveCreature(Creature c) 
        {
            creatures.Remove(c);
        }

        public List<Creature> GetCreatures()
        {
            List<Creature> creaturesList = creatures;
            //get { return new IReadOnlyCollection<List<Creature>>(creaturesList); }
            //return new IReadOnlyCollection<List<Creature>>(creaturesList);
            //return creaturesList.AsReadOnly();
            return creaturesList;
        }
    }
}
