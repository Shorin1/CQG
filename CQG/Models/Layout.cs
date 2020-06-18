using CQG.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQG.Models
{
    public class Layout
    {
        public Player Player { get; } = new Player();
        public List<Enemy> Enemies { get; set; } = new List<Enemy>();

        public bool[,] BlockIsOccupied { get; set; } = new bool[10, 20];

        public Layout()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    BlockIsOccupied[0, i] = true;
                    BlockIsOccupied[9, i] = true;
                    i++;
                }
            }
        }

        public void Clear()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    BlockIsOccupied[i, j] = false;
                }
            }
        }
    }
}
