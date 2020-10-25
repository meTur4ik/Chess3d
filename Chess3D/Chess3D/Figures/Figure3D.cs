using Chess3D.Boards;

namespace Chess3D.Figures
{
    public class Figure3D
    {
        public char Representation { get; } = '.';
        public int[] Position { get; set; } = new int[3];

        public Figure3D()
        {
        }

        public Figure3D(char representation)
        {
            Representation = representation;
        }

        public Figure3D(char representation, int[] position)
        {
            Representation = representation;
            Position = position;
        }

        public virtual int[][] GetAvailableMoves(Board3D board)
        {
            return new int[0][];
        }
    }
}