using SkiaSharp;
using System.IO;

namespace AlchemyColorShaper.Core;

public static class Exporter
{
    public static void ExportPalleteImageAsJpegFile(string filePath, Palette palette, int height, bool inverted)
    {
        var image = palette.GeneratePaletteImage(height, inverted);

        using var memoryStream = new MemoryStream();
        using var managedWStream = new SKManagedWStream(memoryStream);
        image.Encode(managedWStream, SKEncodedImageFormat.Jpeg, 100);

        using var fileStream = new FileStream(filePath, FileMode.Create);
        memoryStream.Seek(0, SeekOrigin.Begin);
        memoryStream.CopyTo(fileStream);
    }

    public static void ExportPalleteImageAsPngFile(string filePath, Palette palette, int height, bool inverted)
    {
        var image = palette.GeneratePaletteImage(height, inverted);

        using var memoryStream = new MemoryStream();
        using var managedWStream = new SKManagedWStream(memoryStream);
        image.Encode(managedWStream, SKEncodedImageFormat.Png, 100);

        using var fileStream = new FileStream(filePath, FileMode.Create);
        memoryStream.Seek(0, SeekOrigin.Begin);
        memoryStream.CopyTo(fileStream);
    }
}
