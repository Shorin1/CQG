using CQG.Models.Enums;
using System;

namespace CQG.Models.Cars
{
    public class Enemy
    {
        // 0_1
        // _2_
        // 345
        // _6_

        private readonly Block[] LEFT_POSITION_BLOCKS = new Block[7]
        {
            new Block() {X = 2, Y = 0 },    // 0
            new Block() {X = 4, Y = 0 },    // 1
            new Block() {X = 3, Y = 0 },    // 2
            new Block() {X = 2, Y = 0 },    // 3
            new Block() {X = 3, Y = 0 },    // 4
            new Block() {X = 4, Y = 0 },    // 5
            new Block() {X = 3, Y = 0 }     // 6
        };

        private readonly Block[] RIGHT_POSITION_BLOCKS = new Block[7]
        {
            new Block() {X = 5, Y = 0 },    // 0
            new Block() {X = 7, Y = 0 },    // 1
            new Block() {X = 6, Y = 0 },    // 2
            new Block() {X = 5, Y = 0 },    // 3
            new Block() {X = 6, Y = 0 },    // 4
            new Block() {X = 7, Y = 0 },    // 5
            new Block() {X = 6, Y = 0 }     // 6
        };

        public Block[] Blocks { get; private set; } = new Block[7]
        {
            new Block(){X = 0, Y = 0 },     // 0
            new Block(){X = 0, Y = 0 },     // 1
            new Block(){X = 0, Y = 0 },     // 2
            new Block(){X = 0, Y = 0 },     // 3
            new Block(){X = 0, Y = 0 },     // 4
            new Block(){X = 0, Y = 0 },     // 5
            new Block(){X = 0, Y = 0 }      // 6
        };

        public int LifeTime { get; private set; } = 25;

        public Enemy()
        {
            RandomPosition();

            Blocks[0].Y = -4;
            Blocks[1].Y = -4;
            Blocks[2].Y = -3;
            Blocks[3].Y = -2;
            Blocks[4].Y = -2;
            Blocks[5].Y = -2;
            Blocks[6].Y = -1;
        }

        private void RandomPosition()
        {
            Random random = new Random();
            int ranValue = random.Next(2);

            switch (ranValue)
            {
                case 0:
                    Blocks = LEFT_POSITION_BLOCKS;
                    break;
                case 1:
                    Blocks = RIGHT_POSITION_BLOCKS;
                    break;
                default:
                    Blocks = LEFT_POSITION_BLOCKS;
                    break;
            }
        }

        public void Tick()
        {
            LifeTime--;

            foreach (Block block in Blocks)
            {
                block.Y++;
            }
        }
    }
}
