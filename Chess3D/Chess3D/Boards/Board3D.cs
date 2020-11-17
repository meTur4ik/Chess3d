using System;
using System.Text;
using Chess3D.Figures;

namespace Chess3D.Boards
{
    public class Board3D
    {
        public Figure3D[,,] Cells { get; set; } = new Figure3D[0, 0, 0];
        public int CellsNum { get; }

        public Board3D()
        {
            
        }

        public Board3D(int cellsNum)
        {
            CellsNum = cellsNum;
            Cells = new Figure3D[cellsNum, cellsNum, cellsNum];
            for (int i = 0; i < cellsNum; i++)
            {
                for (int j = 0; j < cellsNum; j++)
                {
                    for (int k = 0; k < cellsNum; k++)
                    {
                        Cells[i, j, k] = new Figure3D();
                    }
                }
            }
        }

        public void PrintBoard()
        {
            for (int i = 0; i < CellsNum; i++)
            {
                for (int j = CellsNum - 1; j >= 0; j--)
                {
                    Console.WriteLine();
                    var strb = new StringBuilder();
                    for (int k = 0; k < CellsNum; k++)
                    {
                        strb.Append($" {Cells[i, j, k].Representation}");
                    }

                    strb.Append($"  {j + 1}");
                    Console.WriteLine(strb.ToString());
                }

                Console.WriteLine("\n A B C D E F G H");
                Console.WriteLine(new string('-', 20));
            }
        }

        public void SetFigure(int x, int y, int z, Figure3D figure)
        {
            Cells[x, y, z] = figure;
            figure.X = x;
            figure.Y = y;
            figure.Z = z;
        }
    }
}
