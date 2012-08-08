﻿namespace CqrsBattle.Core.Models
{
    public struct Coordinate
    {
        private readonly int _x;
        private readonly int _y;

        public Coordinate(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X
        {
            get { return _x; }
        }

        public int Y
        {
            get { return _y; }
        }
    }
}