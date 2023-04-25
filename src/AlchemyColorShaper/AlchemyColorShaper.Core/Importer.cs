using SkiaSharp;
using System.IO;

namespace AlchemyColorShaper.Core;

public static class Importer
{
    public static SKBitmap ImportImage(string filePath)
    {
        using var fileStream = File.Open(filePath, FileMode.Open);
        var image = SKBitmap.Decode(fileStream);

        return image;
    }
}
