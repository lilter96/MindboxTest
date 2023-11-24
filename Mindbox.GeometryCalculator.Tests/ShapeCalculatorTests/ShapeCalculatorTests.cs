using Mindbox.GeometryCalculator.Shapes;
using Mindbox.GeometryCalculator.Utilities;

namespace Mindbox.GeometryCalculator.Tests.ShapeCalculatorTests;

public class ShapeCalculatorTests
{
    [Fact]
    public void CalculateShapeArea_WithCircle_ReturnsCorrectArea()
    {
        var shape = new Circle(5);
        var calculator = new ShapeCalculator();
        const double expectedArea = Math.PI * 25;
        Assert.Equal(expectedArea, calculator.CalculateShapeArea(shape), 2);
    }

    [Fact]
    public void CalculateShapeArea_WithTriangle_ReturnsCorrectArea()
    {
        var shape = new Triangle(3, 4, 5);
        var calculator = new ShapeCalculator();
        const int expectedArea = 6;
        Assert.Equal(expectedArea, calculator.CalculateShapeArea(shape));
    }
}