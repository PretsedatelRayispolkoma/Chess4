using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibrary
{ 
    public class PieceMaker
    {
        static public Figure Make(string pieceCode, int x, int y)
        {
            Figure figure = null;

            switch (pieceCode)
            {
                case "King":
                case "king":
                case "K":
                case "k":
                    figure = new King(x, y);
                    break;

                case "Bishop":
                case "bishop":
                case "B":
                case "b":
                    figure = new Bishop(x, y);
                break;

                case "Rook":
                case "rook":
                case "R":
                case "r":
                    figure = new Rook(x, y);
                    break;

                case "Queen":
                case "queen":
                case "Q":
                case "q":
                    figure = new Queen(x, y);
                    break;

                case "Knight":
                case "knight":
                case "N":
                case "n":
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

    public class King : Figure
    {
        public King(int X, int Y) : base(X, Y)
        {}

        public override bool IsRightMove(int X, int Y)
        {
            return (Math.Abs(x - X) <= 1 && Math.Abs(y - Y) <= 1);
        }
    }

    public class Bishop : Figure
    {
        public Bishop(int X, int Y) : base(X, Y)
        {}

        public override bool IsRightMove(int X, int Y)
        {
            return (Math.Abs(x - X) == Math.Abs(y - Y));
        }
    }

    public class Rook : Figure
    {
        public Rook(int X, int Y) : base(X, Y)
        {}

        public override bool IsRightMove(int X, int Y)
        {
            return (x == X || y == Y);
        }
    }

    public class Queen : Figure
    {
        public Queen(int X, int Y) : base(X, Y)
        {}

        public override bool IsRightMove(int X, int Y)
        {
            return (x == X || y == Y || Math.Abs(x - X) == Math.Abs(y - Y));
        }
    }

    public class Knight : Figure
    {
        public Knight(int X, int Y) : base(X, Y)
        {}

        public override bool IsRightMove(int X, int Y)
        {
            return ((Math.Abs(x - X) == 2 && Math.Abs(y - Y) == 1) || (Math.Abs(x - X) == 1 && Math.Abs(y - Y) == 2));
        }
    }
}

