using System.Linq;
using Chess3D.Boards;
using Chess3D.Figures;
using NUnit.Framework;

namespace Chess3D.Test
{
    public class KingTests
    {
        private Board3D _board;

        [SetUp]
        public void Setup()
        {
            _board = new KubikschachBoard();
        }

        [Test]
        public void King_ShouldBeAbleToMove()
        {
            var expectedMoves = new int[][]
            {
                new[] {0, 0, 0},
                new[] {0, 0, 1},
                new[] {0, 0, 2},
                new[] {0, 1, 0},
                new[] {0, 1, 1},
                new[] {0, 1, 2},
                new[] {0, 2, 0},
                new[] {0, 2, 1},
                new[] {0, 2, 2},
                new[] {1, 0, 0},
                new[] {1, 0, 1},
                new[] {1, 0, 2},
                new[] {1, 1, 0},
                new[] {1, 1, 2},
                new[] {1, 2, 0},
                new[] {1, 2, 1},
                new[] {1, 2, 2},
                new[] {2, 0, 0},
                new[] {2, 0, 1},
                new[] {2, 0, 2},
                new[] {2, 1, 0},
                new[] {2, 1, 1},
                new[] {2, 1, 2},
                new[] {2, 2, 0},
                new[] {2, 2, 1},
                new[] {2, 2, 2},
            };
            var fig = new King();
            _board.SetFigure(1, 1, 1, fig);

            var moves = fig.GetAvailableMoves(_board);
            foreach (var move in expectedMoves)
            {
                Assert.True(moves.Any(x => x.SequenceEqual(move)));
            }
        }

        [Test]
        public void King_ShouldBeAbleToMoveInCorner()
        {
            var expectedMoves = new int[][]
            {
                new[] {0, 0, 1},
                new[] {0, 1, 0},
                new[] {0, 1, 1},
                new[] {1, 0, 0},
                new[] {1, 0, 1},
                new[] {1, 1, 0},
                new[] {1, 1, 1},
            };

            var fig = new King();
            _board.SetFigure(0, 0, 0, fig);
            var moves = fig.GetAvailableMoves(_board);
            foreach (var move in moves)
            {
                Assert.True(moves.Any(x => x.SequenceEqual(move)));
            }
        }
    }
}