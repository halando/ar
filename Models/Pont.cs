using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ar.Models
{
    internal class Pont
    {
        public Pont()
        {
        }

        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override string? ToString()
        {
            return "("+X+":"+Y+")";
        }

        public Pont(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
