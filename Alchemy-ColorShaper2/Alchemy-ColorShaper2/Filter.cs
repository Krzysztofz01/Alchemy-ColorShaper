using System;
using System.Drawing;

namespace Alchemy_ColorShaper2
{
    class Filter
    {
        //The task of the Filter class is to filter colors with too
        //much similarity based on the ,,threshold" value
        private int threshold;

        public Filter(int inputThreshold)
        {
            threshold = inputThreshold;
        }

        public bool different(Color first, Color second)
        {
            int distanceR = Math.Abs(first.R - second.R);
            int distanceG = Math.Abs(first.G - second.G);
            int distanceB = Math.Abs(first.B - second.B);

            if (distanceR + distanceG + distanceB > this.threshold)
            {
                return false;
            }
            return true;
        }
    }
}