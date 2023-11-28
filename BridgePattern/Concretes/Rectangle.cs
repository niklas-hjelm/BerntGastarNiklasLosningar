using System.Drawing;
using BridgePattern.Abstracts;
using BridgePattern.Interfaces;

namespace BridgePattern.Concretes;

public class Rectangle(RectangleData rectData, IRenderer renderer, Point point) : Shape(renderer, point)
{
    public RectangleData RectangleData { get; set; } = rectData;
    public override void Draw()
    {
        renderer.Rectangle(point, rectData);
    }
}