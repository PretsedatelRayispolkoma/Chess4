using System;
using System.Collections.Generic;
using ChessLibrary;

namespace Chess4
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureName = Console.ReadLine();

            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());

            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            Figure f = PieceMaker.Make(figureName, x1, y1);
            Console.WriteLine(f.IsRightMove(x2, y2) ? "YES" : "NO");
        }
    }
}

