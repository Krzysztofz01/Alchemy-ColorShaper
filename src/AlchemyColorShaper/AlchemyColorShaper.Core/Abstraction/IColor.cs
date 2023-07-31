using System;

namespace AlchemyColorShaper.Core.Abstraction;

public interface IColor
{
    public int R { get; }
    public int G { get; }
    public int B { get; }
    
    public double GetDistance(IColor color);
    public double GetPerceivedBrightness();

    static IColor CreateColor(int red, int green, int blue) => throw new NotImplementedException();
}