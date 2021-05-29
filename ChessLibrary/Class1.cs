using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibrary
{
    class PieceMaker
    {
        static public Figure Make(string pieceCode, int x, int y)
        {
            Figure figure= null;

            switch (pieceCode)
            {
                case "King":
                case "K":
                    figure = new King(x, y);
                    break;

                case "Bishop":
                case "B":
                    figure = new Bishop(x, y);
                    break;

                case "Rook":
                case "R":
                    figure = new Rook(x, y);
                    break;

                case "Queen":
                case "Q":
                    figure = new Queen(x, y);
                    break;

                case "Knight":
                case "N":
                    figure = new Knight(x, y);
                    break;

                default: throw (new Exception("Unknown figure"));
            }

            return figure;
        }

        static public Figure Make(int pieceCode, int x, int y)
        {
            return Make(pieceCode.ToString(), x, y);
        }
    }

    public class Figure
    {
        protected int x;
        protected int y;

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
        {}

        public override bool IsRightMove(int X, int Y)
        {
            return (Math.Abs(x - X) <= 1 && Math.Abs(y - Y) <= 1);
        }
    }

    class Bishop : Figure
    {
        public Bishop(int X, int Y) : base(X, Y)
        {}

        public override bool IsRightMove(int X, int Y)
        {
            return (Math.Abs(x - X) == Math.Abs(y - Y));
        }
    }

    class Rook : Figure
    {
        public Rook(int X, int Y) : base(X, Y)
        {}

        public override bool IsRightMove(int X, int Y)
        {
            return (x == X || y == Y);
        }
    }

    class Queen : Figure
    {
        public Queen(int X, int Y) : base(X, Y)
        {}

        public override bool IsRightMove(int X, int Y)
        {
            return (x == X || y == Y || Math.Abs(x - X) == Math.Abs(y - Y));
        }
    }

    class Knight : Figure
    {
        public Knight(int X, int Y) : base(X, Y)
        {}

        public override bool IsRightMove(int X, int Y)
        {
            return ((Math.Abs(x - X) == 2 && Math.Abs(y - Y) == 1) || (Math.Abs(x - X) == 1 && Math.Abs(y - Y) == 2));
        }
    }
}

