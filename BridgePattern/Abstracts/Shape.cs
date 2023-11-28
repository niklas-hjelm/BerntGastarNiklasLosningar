using System.Drawing;
using BridgePattern.Interfaces;

namespace BridgePattern.Abstracts;

public abstract class Shape(IRenderer renderer, Point point) : IShape
{
    protected IRenderer Renderer { get; set; } = renderer;
    protected Point Point { get; set; } = point;

    public abstract void Draw();
} 