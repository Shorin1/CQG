namespace CQG.Models.Cars
{
    public class Player
    {
        // _0_
        // 123
        // _4_
        // 5_6

        private readonly Block[] LEFT_POSITION_BLOCKS = new Block[7]
        {
            new Block() {X = 3, Y = 16},    // 0
            new Block() {X = 2, Y = 17},    // 1
            new Block() {X = 3, Y = 17},    // 2
            new Block() {X = 4, Y = 17},    // 3
            new Block() {X = 3, Y = 18},    // 4
            new Block() {X = 2, Y = 19},    // 5
            new Block() {X = 4, Y = 19}     // 6
        };

        private readonly Block[] RIGHT_POSITION_BLOCKS = new Block[7]
       {
            new Block() {X = 6, Y = 16},    // 0
            new Block() {X = 7, Y = 17},    // 1
            new Block() {X = 6, Y = 17},    // 2
            new Block() {X = 5, Y = 17},    // 3
            new Block() {X = 6, Y = 18},    // 4
            new Block() {X = 7, Y = 19},    // 5
            new Block() {X = 5, Y = 19}     // 6
       };

        public Block[] Blocks { get; private set; } = new Block[7];

        public Player()
        {
            SetDefaultPoisition();
        }

        public void SetDefaultPoisition()
        {
            Blocks = LEFT_POSITION_BLOCKS;
        }

        public void MoveLeft()
        {
            Blocks = LEFT_POSITION_BLOCKS;
        }

        public void MoveRight()
        {
            Blocks = RIGHT_POSITION_BLOCKS;
        }
    }
}
