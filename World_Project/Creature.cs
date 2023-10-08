using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace World_Project
{
    internal abstract class Creature
    {
        private Cell currentCell;
        private int sight;
        private int energy;

        public Creature(int sight, World world) 
        {
            this.sight = sight;
            this.currentCell = null;
            this.energy = 20;
        }

        public abstract void move();
        public abstract void act();

        public int GetSight()
        {
            return this.sight;
        }
        public void MoveTo(Cell newCell)
        {
            newCell.AddCreature(this);
            this.currentCell.RemoveCreature(this);
            this.currentCell = newCell;
        }

        public List<Cell> GetVisibleCells()
        {
            //Dictionary<int, int> distance = new Dictionary<int, int>();

        }

        public Cell GetCurrentCell()
        {
            return this.currentCell;
        }

        public void Die()
        {
            this.currentCell.RemoveCreature(this);
            this.currentCell = null;
        }

        public void ChangeEnergy(int amount)
        {
            energy += amount;
            if (energy <= 0)
            {
                Die();
            }
        }

        public  int GetEnergy() 
        {
            return this.energy;
        }

        public bool IsAlive()
        {
            if (this.currentCell == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
