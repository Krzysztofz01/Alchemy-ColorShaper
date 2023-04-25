using SkiaSharp;
using System.Linq;

namespace AlchemyColorShaper.Core.Test.Extensions
{
    internal static class ImageAssert
    {
        public static bool ImagesEqual(SKBitmap expected, SKBitmap actual)
        {
            try
            {
                if (expected.Width != actual.Width) return false;
                if (expected.Height != actual.Height) return false;

                foreach (var x in Enumerable.Range(0, expected.Width))
                {
                    foreach (var y in Enumerable.Range(0, expected.Height))
                    {
                        if (expected.GetPixel(x, y) != actual.GetPixel(x, y)) return false;
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
