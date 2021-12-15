using nQueensProblemWithoutStatic.Controller;
using nQueensProblemWithoutStatic.Model;
using System;

namespace nQueensProblemWithoutStatic
{
    class Program
    {
        private static readonly QueensController queensController = new QueensController();
        static void Main(string[] args)
        {
            Console.WriteLine("State the value of N in this program!");
            Queens queens = new Queens();
            queens.N = Convert.ToInt32(Console.ReadLine());
            queens.board = new int[queens.N, queens.N];
            if (!queensController.theBoardSolver(queens, 0))
            {
                Console.WriteLine("Solution not found.");
            }
            queensController.printBoard(queens);
            Console.ReadLine();
        }
    }
}
