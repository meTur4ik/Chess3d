using System;
using Chess3D.Boards;
using Chess3D.Figures;

namespace Chess3D
{
    class Program
    {
        static void Main(string[] args)
        {
            var fig = new Bishop();
            Board3D board = new KubikschachBoard();
            //var fig2 = new Knight();
            //board.Cells[0,0,0] = new Pawn();
            //board.SetFigure(2,3,3, fig2);
            board.SetFigure(2,1,2, fig);
            var moves = fig.GetAvailableMoves(board);
            foreach (var move in moves)
            {
                Console.WriteLine($"{move[0]}, {move[1]}, {move[2]}");
            }
            
            board.PrintBoard();
            /*foreach (var boardCell in board.Cells)
            {
                Console.WriteLine(boardCell.Representation);
            }*/
            //Console.WriteLine(fig.GetAvailableMoves(board)[0][0]);
        }
    }
}
