using Mindbox.GeometryCalculator.Shapes;

namespace Mindbox.GeometryCalculator.Tests.ShapeTests;

public class TriangleTests
{
    [Fact]
    public void CalculateArea_WithValidSides_ReturnsCorrectArea()
    {
        var triangle = new Triangle(3, 4, 5);
        const double expectedArea = 6;
        Assert.Equal(expectedArea, triangle.CalculateArea());
    }

    [Fact]
    public void IsRightAngled_WithRightAngledTriangle_ReturnsTrue()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRightAngled());
    }

    [Fact]
    public void IsRightAngled_WithNonRightAngledTriangle_ReturnsFalse()
    {
        var triangle = new Triangle(3, 3, 3);
        Assert.False(triangle.IsRightAngled());
    }

    [Theory]
    [InlineData(0, 1, 1)]
    [InlineData(-1, 1, 1)]
    [InlineData(1, 0, 1)]
    [InlineData(1, -1, 1)]
    [InlineData(1, 1, 0)]
    [InlineData(1, 1, -1)]
    [InlineData(1, 10, 1)]
    public void Constructor_WithInvalidSides_ThrowsArgumentException(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }
}