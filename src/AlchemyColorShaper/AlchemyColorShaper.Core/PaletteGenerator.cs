using AlchemyColorShaper.Core.Extensions;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AlchemyColorShaper.Core;

public sealed class PaletteGenerator
{
    public static Palette GeneratePalette(SKBitmap bitmap, PaletteGeneratorOptions? options = null)
    {
        if (options is null) options = GetDefaultPaletteGeneratorOptions();

        var scaledBitmap = ScaleBitmap(bitmap, options.ScaleFactor);

        return options.Algorithm switch
        {
            PaletteGeneratorAlgorithm.CountingMethod => GeneratePaletteUsingCountingMethod(scaledBitmap, options),
            PaletteGeneratorAlgorithm.TensorMethod => GeneratePaletteUsingTensorMethod(scaledBitmap, options),
            _ => throw new InvalidOperationException("Unknown PaletteGeneratorAlgorithm specified."),
        };
    }

    public static Task<Palette> GeneratePaletteAsync(SKBitmap bitmap, PaletteGeneratorOptions? options = null, CancellationToken cancellationToken = default)
    {
        return Task.Run(() => GeneratePalette(bitmap, options), cancellationToken);
    }

    private static Palette GeneratePaletteUsingTensorMethod(SKBitmap bitmap, PaletteGeneratorOptions options)
    {
        var colorTensor = new Tensor<List<SKColor>>(3, () => new List<SKColor>());

        foreach (int x in Enumerable.Range(0, bitmap.Width))
        {
            foreach (int y in Enumerable.Range(0, bitmap.Height))
            {
                var color = bitmap.GetPixel(x, y);

                int rIndex = (color.Red > 170) ? 2 : (color.Red < 85) ? 0 : 1;
                int gIndex = (color.Green > 170) ? 2 : (color.Green < 85) ? 0 : 1;
                int bIndex = (color.Blue > 170) ? 2 : (color.Blue < 85) ? 0 : 1;

                colorTensor.GetValue(rIndex, gIndex, bIndex).Add(color);
            }
        }

        var paletteColors = new List<SKColor>();
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
                        rSum += color.Red;
                        gSum += color.Green;
                        bSum += color.Blue;
                    }

                    paletteColors.Add(new SKColor(
                        Convert.ToByte(rSum / colors.Count),
                        Convert.ToByte(gSum / colors.Count),
                        Convert.ToByte(bSum / colors.Count)));
                }
            }
        }

        return (paletteColors.Count > 0)
           ? Palette.CreateFromEnumerable(paletteColors)
           : Palette.CreateEmpty();
    }

    private static Palette GeneratePaletteUsingCountingMethod(SKBitmap bitmap, PaletteGeneratorOptions options)
    {
        var colors = new Dictionary<SKColor, int>();

        foreach (int x in Enumerable.Range(0, bitmap.Width))
        {
            foreach (int y in Enumerable.Range(0, bitmap.Height))
            {
                var color = bitmap.GetPixel(x, y);

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

        var colorQueue = new Queue<SKColor>(colors.OrderByDescending(c => c.Value).Select(p => p.Key));

        var paletteColors = new Stack<SKColor>();
        while (paletteColors.Count < options.MaxEntries)
        {
            if (colorQueue.Count == 0) break;
            var color = colorQueue.Dequeue();

            if (paletteColors.Count == 0)
            {
                paletteColors.Push(color);
                continue;
            }

            int distanceToPrevious = paletteColors.Peek().GetColorDistance(color);
            if (distanceToPrevious > options.ColorThreshold)
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

    private static SKBitmap ScaleBitmap(SKBitmap bitmap, double scaleFactor)
    {
        var width = Convert.ToInt32(bitmap.Width * scaleFactor);
        var height = Convert.ToInt32(bitmap.Height * scaleFactor);

        var scaledBitmap = new SKBitmap(width, height);

        if (!bitmap.ScalePixels(scaledBitmap, SKFilterQuality.High))
            throw new InvalidOperationException("Failed to scaled the image to the given scale factor.");

        return scaledBitmap;
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
