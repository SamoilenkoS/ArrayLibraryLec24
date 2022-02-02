using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayLibrary
{
    public class SquareFigureAdapter : IRoundFigure
    {
        private SquareFigure _squareFigure;

        public double Radius => _squareFigure.Width * Math.Sqrt(2) / 2.0;

        public SquareFigureAdapter(SquareFigure squareFigure)
        {
            _squareFigure = squareFigure;
        }
    }
}
