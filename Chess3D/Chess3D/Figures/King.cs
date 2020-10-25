using Chess3D.Boards;

namespace Chess3D.Figures
{
    public class King : Figure3D
    {
        public King()
        : base('K')
        {
        }

        public override int[][] GetAvailableMoves(Board3D board)
        {
            return base.GetAvailableMoves(board);
        }
    }
}