using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayLibrary
{
    public class RoundHole
    {
        public double Radius { get; private set; }

        public RoundHole(int radius)
        {
            Radius = radius;
        }

        public bool CouldInsert(IRoundFigure figure)
        {
            return Radius >= figure.Radius;
        }
    }
}
