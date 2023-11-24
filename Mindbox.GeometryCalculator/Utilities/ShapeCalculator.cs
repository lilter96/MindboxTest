using Mindbox.GeometryCalculator.Shapes;

namespace Mindbox.GeometryCalculator.Utilities;

public class ShapeCalculator
{
    public double CalculateShapeArea(IShape shape)
    {
        return shape.CalculateArea();
    }
}