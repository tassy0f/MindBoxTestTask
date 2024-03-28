using SquareFigures;

namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [Test]
    public void TestCalculateSquareTriangle_WithSides3_4_5_ReturnsCorrectSquare()
    {
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        var triangle = new Triangle(sideA, sideB, sideC);

        double square = triangle.CalculateSquare();

        Assert.AreEqual(6, square);
    }

    [Test]
    public void TestIsTriangle_WithSides3_4_5_ReturnsTrue()
    {
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        var triangle = new Triangle(sideA, sideB, sideC);

        bool isRightTriangle = triangle.IsTriangle();

        Assert.IsTrue(isRightTriangle);
    }

    [Test]
    public void TestIsTriangle_WithSides5_12_13_ReturnsTrue()
    {
        double sideA = 5;
        double sideB = 12;
        double sideC = 13;
        var triangle = new Triangle(sideA, sideB, sideC);

        bool isRightTriangle = triangle.IsTriangle();

        Assert.IsTrue(isRightTriangle);
    }

    [Test]
    public void TestIsTriangle_WithSides6_8_10_ReturnsFalse()
    {
        double sideA = 6;
        double sideB = 8;
        double sideC = 10;
        var triangle = new Triangle(sideA, sideB, sideC);

        bool isRightTriangle = triangle.IsTriangle();

        Assert.IsTrue(isRightTriangle);
    }

    [Test]
    public void TestCalculateSquareCircleWithRAdius_7_ReturnsCorrectSquare()
    {
        double circleRadius = 7;
        var circle = new Circle(circleRadius);

        var square = circle.CalculateSquare();
        Assert.AreEqual(153.93804002589985, square);

    }
}