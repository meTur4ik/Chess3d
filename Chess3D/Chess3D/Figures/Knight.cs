using System.Collections.Generic;
using Chess3D.Boards;

namespace Chess3D.Figures
{
    public class Knight : Figure3D
    {
        public Knight()
        : base(FigureRepresentation.Knight)
        {
        }

        public override int[][] GetAvailableMoves(Board3D board)
        {
            List<int[]> moves = new List<int[]>();
            var maxPos = board.CellsNum - 1;

            void LastFloor(int floor)
            {
                if (maxPos >= floor && floor >= 0)
                {
                    if (maxPos >= Y - 1 && Y - 1 >= 0)
                        moves.Add(new[] { floor, Y - 1, Z });
                    if (maxPos >= Y + 1 && Y + 1 >= 0)
                        moves.Add(new[] { floor, Y + 1, Z });
                    if (maxPos >= Z - 1 && Z - 1 >= 0)
                        moves.Add(new[] { floor, Y, Z - 1 });
                    if (maxPos >= Z + 1 && Z + 1 >= 0)
                        moves.Add(new[] { floor, Y, Z + 1 });
                }
            }

            void PreLastFloor(int floor)
            {
                if (maxPos >= floor && floor >= 0)
                {
                    if (maxPos >= floor && floor >= 0)
                    {
                        if (maxPos >= Y - 2 && Y - 2 >= 0)
                            moves.Add(new[] { floor, Y - 2, Z });
                        if (maxPos >= Y + 2 && Y + 2 >= 0)
                            moves.Add(new[] { floor, Y + 2, Z });
                        if (maxPos >= Z - 2 && Z - 2 >= 0)
                            moves.Add(new[] { floor, Y, Z - 2 });
                        if (maxPos >= Z + 2 && Z + 2 >= 0)
                            moves.Add(new[] { floor, Y, Z + 2 });
                    }
                }
            }

            void MiddleFloor()
            {
                if (maxPos >= Y - 2 && Y - 2 >= 0)
                {
                    if (maxPos >= Z - 1 && Z - 1 >= 0)
                        moves.Add(new []{X, Y - 2, Z - 1});
                    if (maxPos >= Z + 1 && Z + 1 >= 0)
                        moves.Add(new []{X, Y - 2, Z + 1});
                }

                if (maxPos >= Y - 1 && Y - 1 >= 0)
                {
                    if (maxPos >= Z - 2 && Z - 2 >= 0)
                        moves.Add(new []{X, Y - 1, Z - 2});
                    if (maxPos >= Z + 2 && Z + 2 >= 0)
                        moves.Add(new []{X, Y - 1, Z + 2});
                }

                if (maxPos >= Y + 1 && Y + 1 >= 0)
                {
                    if (maxPos >= Z - 2 && Z - 2 >= 0)
                        moves.Add(new []{X, Y + 1, Z - 2});
                    if (maxPos >= Z + 2 && Z + 2 >= 0)
                        moves.Add(new []{X, Y + 1, Z + 2});
                }

                if (maxPos >= Y + 2 && Y + 2 >= 0)
                {
                    if (maxPos >= Z - 1 && Z - 1 >= 0)
                        moves.Add(new []{X, Y + 2, Z - 1});
                    if (maxPos >= Z + 1 && Z + 1 >= 0)
                        moves.Add(new []{X, Y + 2, Z + 1});
                    
                }
            }

            // floor 1
            LastFloor(X - 2);

            // floor 2
            PreLastFloor(X - 1);

            // floor 3
            MiddleFloor();

            // floor 4
            PreLastFloor(X + 1);

            // floor 5
            LastFloor(X + 2);
            

            return moves.ToArray();
        }
    }
}