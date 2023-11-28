using System.Drawing;
using BridgePattern.Abstracts;
using BridgePattern.Interfaces;

namespace BridgePattern;

public class Circle(double radius, IRenderer renderer, Point point) : Shape(renderer, point)
{
    public double Radius { get; set; } = radius;
    public override void Draw()
    {
       renderer.Circle(point, radius);
    }
}