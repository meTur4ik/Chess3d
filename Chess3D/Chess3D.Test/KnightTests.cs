using System.Linq;
using Chess3D.Boards;
using Chess3D.Figures;
using NUnit.Framework;

namespace Chess3D.Test
{
    public class KnightTests
    {
        private Board3D _board;

        [SetUp]
        public void Setup()
        {
            _board = new KubikschachBoard();
        }

        [Test]
        public void Knight_ShouldBeAbleToMove()
        {
            var fig = new Knight();
            _board.SetFigure(2, 2, 2, fig);

            var expectedMoves = new int[][]
            {
                new []{0, 1, 2},
                new []{0, 2, 1},
                new []{0, 3, 2},
                new []{0, 2, 3},
                new []{1, 0, 2},
                new []{1, 2, 0},
                new []{1, 2, 4},
                new []{1, 4, 2},
                new []{2, 0, 1},
                new []{2, 0, 3},
                new []{2, 1, 0},
                new []{2, 1, 4},
                new []{2, 3, 0},
                new []{2, 3, 4},
                new []{2, 4, 1},
                new []{2, 4, 3},
                new []{3, 0, 2},
                new []{3, 2, 0},
                new []{3, 2, 4},
                new []{3, 4, 2},
                new []{4, 1, 2},
                new []{4, 2, 1},
                new []{4, 2, 3},
                new []{4, 3, 2},
            };

            var resultMoves = fig.GetAvailableMoves(_board);

            Assertions.MovesCollectionContainsCollection(expectedMoves, resultMoves);
            Assertions.MovesCollectionContainsCollection(resultMoves, expectedMoves);
        }

        [Test]
        public void Knight_ShouldNotBeAbleToAttackAlly()
        {
            var knight = new Knight();
            var bishop = new Bishop();
            _board.SetFigure(2, 2, 2, knight);
            _board.SetFigure(0, 1, 2, bishop);

            var expectedMoves = new int[][]
            {
                //new []{0, 1, 2},
                new []{0, 2, 1},
                new []{0, 3, 2},
                new []{0, 2, 3},
                new []{1, 0, 2},
                new []{1, 2, 0},
                new []{1, 2, 4},
                new []{1, 4, 2},
                new []{2, 0, 1},
                new []{2, 0, 3},
                new []{2, 1, 0},
                new []{2, 1, 4},
                new []{2, 3, 0},
                new []{2, 3, 4},
                new []{2, 4, 1},
                new []{2, 4, 3},
                new []{3, 0, 2},
                new []{3, 2, 0},
                new []{3, 2, 4},
                new []{3, 4, 2},
                new []{4, 1, 2},
                new []{4, 2, 1},
                new []{4, 2, 3},
                new []{4, 3, 2},
            };

            var resultMoves = knight.GetAvailableMoves(_board);

            Assertions.MovesCollectionContainsCollection(expectedMoves, resultMoves);
            Assertions.MovesCollectionContainsCollection(resultMoves, expectedMoves);
        }
    }
}
