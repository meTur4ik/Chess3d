﻿using System.Collections.Generic;
using Chess3D.Boards;

namespace Chess3D.Figures
{
    public class King : Figure3D
    {
        public King(FigureSide side=FigureSide.White)
        : base(FigureRepresentation.King, side)
        {
        }

        public override int[][] GetAvailableMoves(Board3D board)
        {
            var moves = new List<int[]>();
            var maxLength = board.CellsNum - 1;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    for (int k = -1; k <= 1; k++)
                    {
                        if (i == 0 && j == 0 && k == 0)
                            continue;
                        if (X + i >= 0 && Y + j >= 0 && Z + k >= 0
                            && X + i <= maxLength && Y + j <= maxLength && Z + k <= maxLength
                            && board.Cells[X + i, Y + j, Z + k].Side != Side)
                        {
                            moves.Add(new []{ X + i, Y + j, Z + k });
                        }
                    }
                }
            }

            return moves.ToArray();
        }
    }
}
