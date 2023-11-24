using Mindbox.GeometryCalculator.Shapes;
using Mindbox.GeometryCalculator.Utilities;

var circle = new Circle(5);
var triangle = new Triangle(3, 4, 5);

var calculator = new ShapeCalculator();

Console.WriteLine("Circle Area: " + calculator.CalculateShapeArea(circle));
Console.WriteLine("Triangle Area: " + calculator.CalculateShapeArea(triangle));
Console.WriteLine("Is Triangle Right Angled: " + triangle.IsRightAngled());