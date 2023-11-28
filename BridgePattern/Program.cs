using System.Drawing;
using BridgePattern;
using BridgePattern.Concretes;
using BridgePattern.Interfaces;
using Common;
using Rectangle = BridgePattern.Concretes.Rectangle;

ILogger logger = new ConsoleLogger();

IRenderer renderer = new BasicRenderer(logger);

IShape shape = new Rectangle(new RectangleData(10, 100), renderer, new Point(10, 10));
IShape shape2 = new Circle(10, renderer, new Point(10, 10));

shape.Draw();
shape2.Draw();

shape = new Rectangle(new RectangleData(15, 10), renderer, new Point(1, 15));
shape2 = new Circle(5, renderer, new Point(5, 5));

shape.Draw();
shape2.Draw();