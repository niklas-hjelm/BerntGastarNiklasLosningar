using System.Drawing;
using BridgePattern.Abstracts;
using Common;

namespace BridgePattern.Concretes;

public class BasicRenderer(ILogger logger) : Renderer(logger)
{
    public override void Circle(Point point, double radius)
    {
        Logger.Log($"Drawing circle at {point.X}, {point.Y} with radius {radius}");
    }

    public override void Rectangle(Point point, RectangleData rec)
    {
        Logger.Log($"Drawing rectangle at {point.X}, {point.Y} with width {rec.Width} and height {rec.Height}");
    }
}