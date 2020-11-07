using Chess3D.Boards;

namespace Chess3D.Figures
{
    public class Figure3D
    {
        public char Representation { get; } = FigureRepresentation.Empty;
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public FigureSide Side { get; }

        public Figure3D()
        {
        }

        public Figure3D(char representation, FigureSide side)
        {
            Representation = representation;
            Side = side;
        }

        public Figure3D(char representation, FigureSide side, int x, int y, int z)
        : this(representation, side)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// returns array of arrays, sized Nx3
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        public virtual int[][] GetAvailableMoves(Board3D board)
        {
            return new int[0][];
        }
    }
}
