using System;
using System.Collections.Generic;
using Chess3D.Boards;

namespace Chess3D.Figures
{
    public class Bishop : Figure3D
    {
        public Bishop(FigureSide side=FigureSide.White)
        : base(FigureRepresentation.Bishop, side)
        {
        }

        public override int[][] GetAvailableMoves(Board3D board)
        {
            var moves = new List<int[]>();
            var maxLength = board.CellsNum - 1;

            bool IsDiagonal(int i, int j, int k)
            {
                if (i == 0)
                {
                    return Math.Abs(j) == Math.Abs(k);
                }

                return Math.Abs(i) == Math.Abs(j) && Math.Abs(j) == Math.Abs(k);
            }

            for (int i = -maxLength; i <= maxLength; i++)
            {
                for (int j = -maxLength; j <= maxLength; j++)
                {
                    for (int k = -maxLength; k <= maxLength; k++)
                    {
                        if (i == 0 && j == 0 && k == 0)
                            continue;
                        if (X + i >= 0 && Y + j >= 0 && Z + k >= 0
                            && X + i <= maxLength && Y + j <= maxLength && Z + k <= maxLength
                            && board.Cells[X + i, Y + j, Z + k].Side != Side
                            && IsDiagonal(i, j, k))
                        {
                            moves.Add(new[] { X + i, Y + j, Z + k });
                        }
                    }
                }
            }

            return moves.ToArray();
        }
    }
}
