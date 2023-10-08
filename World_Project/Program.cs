using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Halasi-Czalbert Tibor

            ////Testing width and height
            //World w = new World(5, 3);
            //Console.WriteLine(w.GetWidth() == 5);
            //Console.WriteLine(w.GetHeight() == 3);

            //// Testing cell coordinates
            //Console.WriteLine(w.GetCell(1, 2).GetX() == 1);
            //Console.WriteLine(w.GetCell(1, 2).GetY() == 2);

            //// Testing if the cells are persistent
            //Console.WriteLine(w.GetCell(1, 1) == w.GetCell(1, 1));

            //// Testing getCellList ()
            //List<Cell> cells = w.GetCellList();
            //Console.WriteLine(cells.Count == w.GetWidth() * w.GetHeight());
            //Console.WriteLine(cells.Contains(w.GetCell(0, 0)));
            //Console.WriteLine(cells.Contains(w.GetCell(4, 0)));
            //Console.WriteLine(cells.Contains(w.GetCell(0, 2)));
            //Console.WriteLine(cells.Contains(w.GetCell(4, 2)));

            ////Testing getCreatures()
            //Carnivore c1 = new Carnivore();
            //Carnivore c2 = new Carnivore();
            //c1.MoveTo(w.GetCell(1, 2));
            //c2.MoveTo(w.GetCell(2, 1));
            //List<Creature> allCreatures = w.GetCreatures();
            //Console.WriteLine(allCreatures.Count == 2);
            //Console.WriteLine(allCreatures.Contains(c1));
            //Console.WriteLine(allCreatures.Contains(c2));

            Console.WriteLine("\n--------------------------------------------\n");

            //World w1 = new World(4, 1);
            //Cell a = w1.GetCell(0, 0);
            //Cell b = w1.GetCell(1, 0);
            //Cell c = w1.GetCell(2, 0);
            //Cell d = w1.GetCell(3, 0);
            //a.ChangePlants(30);
            //b.ChangePlants(20);
            //Console.WriteLine(a.GetPlants());
            //Console.WriteLine(b.GetPlants());

            Console.ReadKey();
        }
    }
}
