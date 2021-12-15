using nQueensProblemWithoutStatic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nQueensProblemWithoutStatic.Controller
{
    public class QueensController
    {
        public void printBoard(Queens queens)
        {
            for (int i = 0; i < queens.N; i++)
            {
                for (int j = 0; j < queens.N; j++)
                {
                    Console.Write(queens.board[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
        public Boolean toPlaceOrNotToPlace(Queens queens, int row, int col)
        {
            int i, j;
            for (i = 0; i < col; i++)
            {
                if (queens.board[row, i] == 1) return false;
            }
            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (queens.board[i, j] == 1) return false;
            }
            for (i = row, j = col; j >= 0 && i < queens.N; i++, j--)
            {
                if (queens.board[i, j] == 1) return false;
            }
            return true;
        }
        public Boolean theBoardSolver(Queens queens, int col)
        {
            if (col >= queens.N) return true;
            for (int i = 0; i < queens.N; i++)
            {
                if (toPlaceOrNotToPlace(queens, i, col))
                {
                    queens.board[i, col] = 1;
                    if (theBoardSolver(queens, col + 1)) return true;
                    // Backtracking is hella important in this one.  
                    queens.board[i, col] = 0;
                }
            }
            return false;
        }
    }
}
