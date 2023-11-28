using System.Drawing;
using BridgePattern.Concretes;
using BridgePattern.Interfaces;
using Common;

namespace BridgePattern.Abstracts;

public abstract class Renderer(ILogger logger) : IRenderer
{
    protected ILogger Logger { get; set; } = logger;

    public abstract void Circle(Point point, double radius);

    public abstract void Rectangle(Point point, RectangleData rec);
}