using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Engine
    {
        public int size;
        public int movesCount = 0;
        public string[,] board;

        public Engine(int size)
        {
            this.size = size;
            this.board = new string[size, size];
        }

        public int CheckFinish(int x, int y)
        {
            if (size > 3)
            {
                int winningSize;
                int cellsCount;
                if (size == 4)
                {
                    cellsCount = 2;
                    winningSize = 3;
                    return CalcMoreDim(winningSize, cellsCount, x, y);
                }
                else
                {
                    winningSize = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(size) / 2));
                    if (size % 2 == 0)
                        cellsCount = winningSize + 1;
                    else
                        cellsCount = winningSize;
                    return CalcMoreDim(winningSize, cellsCount, x, y);
                }
            }
            else //for 3
            {
                int colX = 0, rowX = 0, diagX = 0, sdiagX = 0, colO = 0, rowO = 0, diagO = 0, sdiagO = 0;
                for (int i = 0; i < size; i++)
                {
                    if (this.board[x, i] == "X") colX++;
                    if (this.board[x, i] == "O") colO++;
                    if (this.board[i, y] == "X") rowX++;
                    if (this.board[i, y] == "O") rowO++;
                    if (this.board[i, i] == "X") diagX++;
                    if (this.board[i, i] == "O") diagO++;
                    if (this.board[i, size - i - 1] == "X") sdiagX++;
                    if (this.board[i, size - i - 1] == "O") sdiagO++;
                    if (colX == size || rowX == size || diagX == size || sdiagX == size)
                    {
                        return 1;
                    }
                    else if (colO == size || rowO == size || diagO == size || sdiagO == size)
                    {
                        return 2;
                    }
                }
                if (this.movesCount == size * size) return 0;
                return 3;
            }
        }

        private int CalcMoreDim(int winningSize, int cellsCount, int x, int y) // for >3
        {
            int colX = 0, rowX = 0, diagX = 0, sdiagX = 0, colO = 0, rowO = 0, diagO = 0, sdiagO = 0;
            for (int j = 0; j < cellsCount; j++)
            {
                for (int i = j; i < winningSize + j; i++)
                {
                    if (this.board[x, i] == "X") colX++;
                    if (this.board[x, i] == "O") colO++;
                    if (this.board[i, y] == "X") rowX++;
                    if (this.board[i, y] == "O") rowO++;
                    if (this.board[i, i] == "X") diagX++;
                    if (this.board[i, i] == "O") diagO++;
                    if (this.board[i, size - i - 1] == "X") sdiagX++;
                    if (this.board[i, size - i - 1] == "O") sdiagO++;
                    if (colX == winningSize || rowX == winningSize || diagX == winningSize || sdiagX == winningSize)
                    {
                        return 1;

                    }
                    else if (colO == winningSize || rowO == winningSize || diagO == winningSize || sdiagO == winningSize)
                    {
                        return 2;
                    }
                }
                colX = 0; rowX = 0; diagX = 0; sdiagX = 0; colO = 0; rowO = 0; diagO = 0; sdiagO = 0;
            }
            if (this.movesCount == size * size) return 0;
            return 3;
        }
    }
}
