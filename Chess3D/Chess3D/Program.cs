using System;
using Chess3D.Boards;
using Chess3D.Figures;

namespace Chess3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure3D fig = new Figure3D();
            Board3D board = new KubikschachBoard();
            board.Cells[0,0,0] = new Pawn();
            board.PrintBoard();
            /*foreach (var boardCell in board.Cells)
            {
                Console.WriteLine(boardCell.Representation);
            }*/
            //Console.WriteLine(fig.GetAvailableMoves(board)[0][0]);
        }
    }
}
