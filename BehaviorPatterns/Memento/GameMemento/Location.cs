using System;
using System.Collections.Generic;
using System.Text;

namespace Locations
{
    public class Location
    {
        public int X;
        public int Y;
        public int Z;

        public Location(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Location Change(int x, int y, int z)
        {
            return new Location(X + x, Y + y, Z + z);
        }

        public string Get()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}
