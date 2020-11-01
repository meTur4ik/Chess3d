using System;
using Chess3D.Boards;
using Chess3D.Figures;

namespace Chess3D
{
    class Program
    {
        static void Main(string[] args)
        {
            var fig = new Knight();
            Board3D board = new KubikschachBoard();
            //board.Cells[0,0,0] = new Pawn();
            board.SetFigure(2,2,2, fig);
            var moves = fig.GetAvailableMoves(board);
            foreach (var move in moves)
            {
                Console.WriteLine($"{move[0]}, {move[1]}, {move[2]}");
            }
            
            //board.PrintBoard();
            /*foreach (var boardCell in board.Cells)
            {
                Console.WriteLine(boardCell.Representation);
            }*/
            //Console.WriteLine(fig.GetAvailableMoves(board)[0][0]);
        }
    }
}
