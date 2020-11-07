using System;
using System.Collections.Generic;
using Chess3D.Boards;

namespace Chess3D.Figures
{
    public class Pawn : Figure3D
    {
        public Pawn(FigureSide side=FigureSide.White)
        : base(FigureRepresentation.Pawn, side)
        {
        }

        public override int[][] GetAvailableMoves(Board3D board)
        {
            var moves = new List<int[]>();
            var direction = Side switch
            {
                FigureSide.White => 1,
                FigureSide.Black => -1,
                _ => throw new InvalidOperationException("only white and black sides now supported")
            };

            for (int i = X - 1; i <= X + 1; i++)
            {
                if (!(board.CellsNum > i && i >= 0))
                    continue;
                for (int k = Z - 1; k <= Z + 1; k++)
                {
                    if (!(board.CellsNum > k && k >= 0 && board.CellsNum > Y + direction && Y + direction >= 0))
                        continue;

                    if (k == Z && board.Cells[i, Y + direction, k].Representation == FigureRepresentation.Empty
                        || k != Z && board.Cells[i, Y + direction, k].Representation != FigureRepresentation.Empty && 
                        board.Cells[i, Y + direction, k].Side != Side)
                    {
                        moves.Add(new [] {i, Y + direction, k});
                    }
                }
            }

            return moves.ToArray();
        }
    }
}
