using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayLibrary
{
    public class RoundFigure : IRoundFigure
    {
        public double Radius { get; private set; }

        public RoundFigure(int radius)
        {
            Radius = radius;
        }
    }
}
