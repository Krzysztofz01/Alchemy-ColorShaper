using System;

namespace AlchemyColorShaper.Core.Abstraction;

public interface IImage
{
    int Width { get; }
    int Height { get;}

    IColor GetPixel(int x, int y);
    void SetPixel(int x, int y, IColor color);
    IImage Scale(double scaleFactor);

    static IImage CreateImage(int width, int height) => throw new NotImplementedException();
    static IImage ImportFromFile(string path) => throw new NotImplementedException();
    static void ExportToFile(string path) => throw new NotImplementedException();
}