using System.Drawing;
using BridgePattern.Concretes;

namespace BridgePattern.Interfaces;

public interface IRenderer
{
    void Circle(Point point, double radius);
    void Rectangle(Point point, RectangleData rec);
}