using Chess3D.Boards;
using Chess3D.Figures;
using NUnit.Framework;

namespace Chess3D.Test
{
    public class PawnTests
    {
        private Board3D _board;

        [SetUp]
        public void Setup()
        {
            _board = new KubikschachBoard();
        }

        [Test]
        public void Pawn_ShouldBeAbleToMove()
        {
            var pawn = new Pawn();
            _board.SetFigure(2, 2, 2, pawn);

            var expectedMoves = new int[][]
            {
                new []{1, 3, 2},
                new []{2, 3, 2},
                new []{3, 3, 2},
            };

            var resultMoves = pawn.GetAvailableMoves(_board);

            Assertions.MovesCollectionContainsCollection(expectedMoves, resultMoves);
            Assertions.MovesCollectionContainsCollection(resultMoves, expectedMoves);
        }

        [Test]
        public void Pawn_BlackShouldBeAbleToMove()
        {
            var pawn = new Pawn(FigureSide.Black);
            _board.SetFigure(2, 2, 2, pawn);

            var expectedMoves = new int[][]
            {
                new []{1, 1, 2},
                new []{2, 1, 2},
                new []{3, 1, 2}
            };

            var resultMoves = pawn.GetAvailableMoves(_board);

            Assertions.MovesCollectionContainsCollection(expectedMoves, resultMoves);
            Assertions.MovesCollectionContainsCollection(resultMoves, expectedMoves);
        }

        [Test]
        public void Pawn_ShouldBeAbleToStrikeFigure()
        {
            var pawn = new Pawn();
            var knight = new Knight(FigureSide.Black);
            _board.SetFigure(1, 2, 0, pawn);
            _board.SetFigure(2, 3, 1, knight);

            var expectedMoves = new int[][]
            {
                new []{0, 3, 0},
                new []{1, 3, 0},
                new []{2, 3, 0},
                new []{2, 3, 1}
            };

            var resultMoves = pawn.GetAvailableMoves(_board);

            Assertions.MovesCollectionContainsCollection(expectedMoves, resultMoves);
            Assertions.MovesCollectionContainsCollection(resultMoves, expectedMoves);
        }

        [Test]
        public void Pawn_ShouldNotBeAbleToStrikeAlly()
        {
            var pawn = new Pawn();
            var knight = new Knight(FigureSide.White);
            _board.SetFigure(1, 2, 0, pawn);
            _board.SetFigure(2, 3, 1, knight);

            var expectedMoves = new int[][]
            {
                new []{0, 3, 0},
                new []{1, 3, 0},
                new []{2, 3, 0},
                //new []{2, 3, 1}
            };

            var resultMoves = pawn.GetAvailableMoves(_board);

            Assertions.MovesCollectionContainsCollection(expectedMoves, resultMoves);
            Assertions.MovesCollectionContainsCollection(resultMoves, expectedMoves);
        }
    }
}