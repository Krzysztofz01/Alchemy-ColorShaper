using AlchemyColorShaper.Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AlchemyColorShaper.Core;

public sealed class PaletteGenerator
{
    public static Palette GeneratePalette(IImage image, PaletteGeneratorOptions? options = null)
    {
        if (options is null) options = GetDefaultPaletteGeneratorOptions();

        var scaledImage = image.Scale(options.ScaleFactor);

        return options.Algorithm switch
        {
            PaletteGeneratorAlgorithm.CountingMethod => GeneratePaletteUsingCountingMethod(scaledImage, options),
            PaletteGeneratorAlgorithm.TensorMethod => GeneratePaletteUsingTensorMethod(scaledImage, options),
            _ => throw new InvalidOperationException("Unknown PaletteGeneratorAlgorithm specified."),
        };
    }

    public static Task<Palette> GeneratePaletteAsync(IImage image, PaletteGeneratorOptions? options = null, CancellationToken cancellationToken = default)
    {
        return Task.Run(() => GeneratePalette(image, options), cancellationToken);
    }

    private static Palette GeneratePaletteUsingTensorMethod(IImage image, PaletteGeneratorOptions options)
    {
        var colorTensor = new Tensor<List<IColor>>(3, () => new List<IColor>());

        foreach (int x in Enumerable.Range(0, image.Width))
        {
            foreach (int y in Enumerable.Range(0, image.Height))
            {
                var color = image.GetPixel(x, y);

                int rIndex = (color.R > 170) ? 2 : (color.R < 85) ? 0 : 1;
                int gIndex = (color.G > 170) ? 2 : (color.G < 85) ? 0 : 1;
                int bIndex = (color.B > 170) ? 2 : (color.B < 85) ? 0 : 1;

                colorTensor.GetValue(rIndex, gIndex, bIndex).Add(color);
            }
        }

        var paletteColors = new List<IColor>();
        foreach (int x in Enumerable.Range(0, 3))
        {
            foreach (int y in Enumerable.Range(0, 3))
            {
                foreach (int z in Enumerable.Range(0, 3))
                {
                    var colors = colorTensor.GetValue(x, y, z);
                    if (colors.Count == 0) continue;

                    long rSum = 0;
                    long gSum = 0;
                    long bSum = 0;

                    foreach (var color in colors)
                    {
                        rSum += color.R;
                        gSum += color.G;
                        bSum += color.B;
                    }

                    paletteColors.Add(IColor.CreateColor(
                        Convert.ToInt32(rSum / colors.Count),
                        Convert.ToInt32(gSum / colors.Count),
                        Convert.ToInt32(bSum / colors.Count)));
                }
            }
        }

        return (paletteColors.Count > 0)
           ? Palette.CreateFromEnumerable(paletteColors)
           : Palette.CreateEmpty();
    }

    private static Palette GeneratePaletteUsingCountingMethod(IImage image, PaletteGeneratorOptions options)
    {
        var colors = new Dictionary<IColor, int>();

        foreach (int x in Enumerable.Range(0, image.Width))
        {
            foreach (int y in Enumerable.Range(0, image.Height))
            {
                var color = image.GetPixel(x, y);

                if (colors.ContainsKey(color))
                {
                    colors[color] += 1;
                }
                else
                {
                    colors.Add(color, 1);
                }
            }
        }

        var colorQueue = new Queue<IColor>(colors.OrderByDescending(c => c.Value).Select(p => p.Key));

        var paletteColors = new Stack<IColor>();
        while (paletteColors.Count < options.MaxEntries)
        {
            if (colorQueue.Count == 0) break;
            var color = colorQueue.Dequeue();

            if (paletteColors.Count == 0)
            {
                paletteColors.Push(color);
                continue;
            }

            var distanceToPrevious = paletteColors.Peek().GetDistance(color);
            if (distanceToPrevious * 255.0 > options.ColorThreshold)
            {
                paletteColors.Push(color);
                continue;
            }
        }

        return (paletteColors.Count > 0)
            ? Palette.CreateFromEnumerable(paletteColors)
            : Palette.CreateEmpty();
    }

    private PaletteGenerator() {}
    public static PaletteGenerator Create() => new();

    private static PaletteGeneratorOptions GetDefaultPaletteGeneratorOptions()
    {
        return new PaletteGeneratorOptions
        {
            Algorithm = PaletteGeneratorAlgorithm.TensorMethod,
            ScaleFactor = 0.5d,
            ColorThreshold = 50,
            MaxEntries = 1
        };
    }
}

public sealed class PaletteGeneratorOptions
{
    public PaletteGeneratorAlgorithm Algorithm { get; init; }
    public double ScaleFactor { get; init; }
    public int ColorThreshold { get; init; }
    public int MaxEntries { get; init; }

    public bool IsValid()
    {
        if (ScaleFactor > 1.0d || ScaleFactor < 0.0d) return false;

        if (ColorThreshold < 0) return false;

        if (MaxEntries < 1) return false;

        return true;
    }
}
public enum PaletteGeneratorAlgorithm
{
    CountingMethod,
    TensorMethod
}
