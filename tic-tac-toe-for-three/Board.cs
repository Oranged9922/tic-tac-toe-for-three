namespace tic_tac_toe_for_three
{
    internal class Board
    {
        public Board(int sizeX = 5, int sizeY =5)
        {
            SizeX = sizeX < 5 ? 5 : sizeX;
            SizeY = sizeY < 5 ? 5 : sizeY;
            board = new PlayerType[sizeX,sizeY];
        }

        public int SizeX { get; }
        public int SizeY { get; }
        private PlayerType[,] board;

        public bool IsWin(out PlayerType? t, int minimumToWin = 3)
        {
            // check row, column and both diagonals
            // can be optimized
            // go over the board with mask of size covering minimum to win
            // base case 3x3
            int startindexX = 1;
            int lastindexX = SizeX - 1;
            int startindexY = 1;
            int lastindexY = SizeY - 1;
            for (int i = startindexY; i < lastindexY; i++)
            {
                for(int j = startindexX; j < lastindexX; j++)
                {
                    // i, j is middle of 3x3 mask on top of the board
                    if( )
                }
            }

        }
    }
}
