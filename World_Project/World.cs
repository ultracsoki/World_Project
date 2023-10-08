using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace World_Project
{
    internal class World
    {
        private Cell[,] map;
        private int width;
        private int height;
        public List<Cell> cells = new List<Cell>();

        public World(int w, int h)
        {
            this.width = w;
            this.height = h;
            this.map = new Cell[w, h];
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    this.map[i, j] = new Cell(this,i,j);
                    cells.Add(this.map[i, j]);
                }
            }
        }

        public int GetWidth()
        {
            return this.width;
        }

        public int GetHeight()
        {
            return this.height;
        }

        public Cell GetCell(int x, int y) 
        {
            if (x >= this.width || x < 0)
            {
                throw new ArgumentException("Rosszul adta meg az adott cella 'x' indexű elemét.", nameof(x));
            }
            else if (y >= this.height || y < 0)
            {
                throw new ArgumentException("Rosszul adta meg az adott cella 'y' indexű elemét.", nameof(y));
            }
            else
            {
                return this.map[x, y];
            }
        }

        public List<Cell> GetCellList()
        {
            List<Cell> cellList = this.cells;
            return cellList;
        }

        public List<Creature> GetCreatures()
        {
            List<Creature> allCreatures = new List<Creature>();
            for (int i = 0; i < this.cells.Count; i++)
            {
                for (int k = 0; k < this.cells[i].GetCreatures().Count; k++)
                {
                    allCreatures.Add(this.cells[i].GetCreatures()[k]);
                }
            }
            return allCreatures;
        }
    }
}
