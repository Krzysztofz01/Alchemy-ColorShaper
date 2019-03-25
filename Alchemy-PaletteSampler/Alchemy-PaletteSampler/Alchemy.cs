using System.Drawing;

namespace Alchemy_PaletteSampler
{
    class Alchemy
    {
        public static string toHex(Color a)
        {
            string hex = a.R.ToString("X2") + a.G.ToString("X2") + a.B.ToString("X2");
            return "#" + hex;
        }
    }
}
