using System;

namespace Chess4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());

            King king = new King(x1, y1);
            Console.WriteLine(king.IsRightMove(x1, y1));

            Queen queen = new Queen(x1, y1);
            Console.WriteLine(queen.IsRightMove(x1, y1));

            Knight knight = new Knight(x1, y1);
            Console.WriteLine(knight.IsRightMove(x1, y1));

            Rook rook = new Rook(x1, y1);
            Console.WriteLine(rook.IsRightMove(x1, y1));

            Bishop bishop = new Bishop(x1, y1);
            Console.WriteLine(bishop.IsRightMove(x1, y1));
        }
    }

    class Figure
    {
        public int x;
        public int y;

        public Figure(int X, int Y)
        {
            x = X;
            y = Y;
        }

        public virtual bool IsRightMove(int X, int Y)
        {
            return false;
        }
    }

    class King : Figure
    {
        public King(int X, int Y) : base(X, Y)
        {

        }

        public override bool IsRightMove(int X, int Y)
        {
            return (Math.Abs(x - X) <= 1 && Math.Abs(y - Y) <= 1);
        }
    }

    class Bishop : Figure
    {
        public Bishop(int X, int Y) : base(X, Y)
        {

        }

        public override bool IsRightMove(int X, int Y)
        {
            return (Math.Abs(x - X) == Math.Abs(y - Y));
        }
    }

    class Rook : Figure
    {
        public Rook(int X, int Y) : base(X, Y)
        {

        }

        public override bool IsRightMove(int X, int Y)
        {
            return (x == X || y == Y);
        }
    }

    class Queen : Figure
    {
        public Queen(int X, int Y) : base(X, Y)
        {

        }

        public override bool IsRightMove(int X, int Y)
        {
            return (x == X || y == Y || Math.Abs(x - X) == Math.Abs(y - Y));
        }
    }

    class Knight : Figure
    {
        public Knight(int X, int Y) : base(X, Y)
        {

        }

        public override bool IsRightMove(int X, int Y)
        {
            return ((Math.Abs(x - X) == 2 && Math.Abs(y - Y) == 1) || (Math.Abs(x - X) == 1 && Math.Abs(y - Y) == 2));
        }
    }
}

