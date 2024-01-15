namespace Exercises_1_Solution
{
    internal class TurningLightOn
    {
        public int minFlips(String[] board)
        {
            int flips = 0;
            int row = board.Length;
            int col = board[0].Length;

            char[,] grid = new char[row,col];
            for(int i=0; i<row; i++)
            {
                for(int j=0; j<col; j++)
                {
                    grid[i,j]= board[i][j];
                }
            }

            for (int i = row - 1; i >= 0; i--)
            {
                for (int j = col - 1; j >= 0; j--)
                {
                    if (grid[i,j] == '0') { flip(grid,i,j);flips++; }   
                }
            }
            return flips;
        }

        public void flip(char[,] grid, int raw, int col)
        {
            for(int i = raw; i >= 0; i--)
            {
                for (int j = col; j >= 0; j--)
                {
                    if (grid[i, j] == '0')
                    {
                        grid[i, j] = '1';
                    }
                    else { grid[i, j] = '0'; }
                }
            }
        }
    }
}
