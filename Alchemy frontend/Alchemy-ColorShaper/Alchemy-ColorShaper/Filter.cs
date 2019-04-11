using System;
using System.Drawing;

namespace Alchemy_PaletteSampler
{
    class Filter
    {
        int threshold;

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