using SkiaSharp;
using System;

namespace AlchemyColorShaper.Core.Extensions;

internal static class SKColorExtensions
{
    public static int GetColorDistance(this SKColor color, SKColor value)
    {
        var rDiff = Math.Abs(color.Red - value.Red);
        var gDiff = Math.Abs(color.Green - value.Green);
        var bDiff = Math.Abs(color.Blue - value.Blue);

        return rDiff + gDiff + bDiff;
    }

    public static double GetPerceivedBrightness(this SKColor color)
    {
        var luminance = GetLuminance(color);

        if (luminance <= 216.0d / 24389.0d)
            return (luminance * (24389.0 / 27.0)) / 100.0;

        return Math.Pow(luminance, 1.0d / 3.0d) * 116.0d - 16.0d;
    }

    private static double GetLuminance(SKColor color)
    {
        var rNormalized = color.Red / 255.0d;
        var gNormalized = color.Green / 255.0d;
        var bNormalized = color.Blue / 255.0d;

        var rLinear = GetLinearRgbComponent(rNormalized);
        var gLinear = GetLinearRgbComponent(gNormalized);
        var bLinear = GetLinearRgbComponent(bNormalized);

        return rLinear * 0.2126 + gLinear * 0.7152 + bLinear * 0.0722;
    }

    private static double GetLinearRgbComponent(double component)
    {
        if (component > 1.0d || component < 0.0d)
            throw new ArgumentOutOfRangeException(nameof(component));

        if (component <= 0.04045d) return component / 12.92d;

        return Math.Pow((component + 0.055d) / 1.055d, 2.4d);
    }
}
