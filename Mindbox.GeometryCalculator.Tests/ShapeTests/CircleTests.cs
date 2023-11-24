using Mindbox.GeometryCalculator.Shapes;

namespace Mindbox.GeometryCalculator.Tests.ShapeTests;

public class CircleTests
{
    [Fact]
    public void CalculateArea_WithPositiveRadius_ReturnsCorrectArea()
    {
        var circle = new Circle(5);
        const double expectedArea = Math.PI * 25;
        Assert.Equal(expectedArea, circle.CalculateArea(), 2);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void Constructor_WithInvalidRadius_ThrowsArgumentException(double invalidRadius)
    {
        Assert.Throws<ArgumentException>(() => new Circle(invalidRadius));
    }
}