using Chess3D.Boards;
using Chess3D.Figures;
using NUnit.Framework;

namespace Chess3D.Test
{
    public class BishopTests
    {
        private Board3D _board;

        [SetUp]
        public void Setup()
        {
            _board = new KubikschachBoard();
        }

        [Test]
        public void Bishop_ShouldBeAbleToMove()
        {
            var expectedMoves = new int[][]
            {
                new[]{0, 1, 3},
                new[]{0, 5, 3},
                new[]{1, 2, 2},
                new[]{1, 2, 0},
                new[]{1, 4, 0},
                new[]{1, 4, 2},
                new[]{2, 0, 4},
                new[]{2, 1, 3},
                new[]{2, 2, 2},
                new[]{2, 2, 0},
                new[]{2, 4, 0},
                new[]{2, 4, 2},
                new[]{2, 5, 3},
                new[]{2, 6, 4},
                new[]{2, 7, 5},
                new[]{3, 2, 2},
                new[]{3, 2, 0},
                new[]{3, 4, 0},
                new[]{3, 4, 2},
                new[]{4, 1, 3},
                new[]{4, 5, 3},
                new[]{5, 0, 4},
                new[]{5, 6, 4},
                new[]{6, 7, 5},
            };

            var fig = new Bishop();
            _board.SetFigure(2, 3, 1, fig);

            var resultMoves = fig.GetAvailableMoves(_board);
            Assertions.MovesCollectionContainsCollection(expectedMoves, resultMoves);
            Assertions.MovesCollectionContainsCollection(resultMoves, expectedMoves);
        }
    }
}