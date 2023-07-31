using AlchemyColorShaper.Core.Abstraction;
using AlchemyColorShaper.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlchemyColorShaper.Core;

public sealed class Palette
{
    private readonly List<IColor> _colors = new();
    public IReadOnlyCollection<IColor> Colors => _colors.AsReadOnly();

    public IImage GeneratePaletteImage(int height, bool inverted)
    {
        if (height <= 0) throw new ArgumentOutOfRangeException(nameof(height), "Height values must be greater than zero.");

        var paletteColors = inverted
            ? Colors.Reverse()
            : Colors;

        int width = height / paletteColors.Count;
        var image = IImage.CreateImage(width, height);

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
    private Palette(IEnumerable<IColor> colors) => _colors = colors.ToList();

    public static Palette CreateEmpty() =>
        new(Enumerable.Empty<IColor>());

    public static Palette CreateFromEnumerable(IEnumerable<IColor> colors) =>
        new(colors.OrderByDescending(c => c.GetPerceivedBrightness()));
}
