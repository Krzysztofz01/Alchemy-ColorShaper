using AlchemyColorShaper.Core.Extensions;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlchemyColorShaper.Core;

public sealed class Palette
{
    private readonly List<SKColor> _colors = new();
    public IReadOnlyCollection<SKColor> Colors => _colors.AsReadOnly();

    public SKBitmap GeneratePaletteImage(int height, bool inverted)
    {
        if (height <= 0) throw new ArgumentOutOfRangeException(nameof(height), "Height values must be greater than zero.");

        var paletteColors = inverted
            ? Colors.Reverse()
            : Colors;

        int width = height / paletteColors.Count;
        var image = new SKBitmap(width, height);

        foreach (int y in Enumerable.Range(0, height))
        {
            int colorIndex = Math.Max(0, Math.Min(paletteColors.Count - 1, y / width));
            var color = paletteColors.ElementAt(colorIndex);

            foreach (int x in Enumerable.Range(0, width))
            {
                image.SetPixel(x, y, color);
            }
        }

        return image;
    }

    private Palette() { }
    private Palette(IEnumerable<SKColor> colors) => _colors = colors.ToList();

    public static Palette CreateEmpty() =>
        new(Enumerable.Empty<SKColor>());

    public static Palette CreateFromEnumerable(IEnumerable<SKColor> colors) =>
        new(colors.OrderByDescending(c => c.GetPerceivedBrightness()));
}
