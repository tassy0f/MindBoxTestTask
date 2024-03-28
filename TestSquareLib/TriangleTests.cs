using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareFigures;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestSquareLib;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void TestCalculateSquareTriangle_WithSides3_4_5_ReturnsCorrectSquare()
    {
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        var triangle = new Triangle(sideA, sideB, sideC);

        double square = triangle.CalculateSquare();

        Assert.AreEqual(6, square);
    }

    [TestMethod]
    public void TestIsTriangle_WithSides3_4_5_ReturnsTrue()
    {
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        var triangle = new Triangle(sideA, sideB, sideC);

        bool isRightTriangle = triangle.IsTriangle();

        Assert.IsTrue(isRightTriangle);
    }

    [TestMethod]
    public void TestIsTriangle_WithSides5_12_13_ReturnsTrue()
    {
        double sideA = 5;
        double sideB = 12;
        double sideC = 13;
        var triangle = new Triangle(sideA, sideB, sideC);

        bool isRightTriangle = triangle.IsTriangle();

        Assert.IsTrue(isRightTriangle);
    }

    [TestMethod]
    public void TestIsTriangle_WithSides6_8_10_ReturnsFalse()
    {
        double sideA = 6;
        double sideB = 8;
        double sideC = 10;
        var triangle = new Triangle(sideA, sideB, sideC);

        bool isRightTriangle = triangle.IsTriangle();

        Assert.IsTrue(isRightTriangle);
    }

    [TestMethod]
    public void TestCalculateSquareCircleWithRAdius_7_91_ReturnsCorrectSquare()
    {
        double circleRadius = 7.91;
        var circle = new Circle(circleRadius);

        var square = circle.CalculateSquare();
        Assert.AreEqual(196.563483, square);

    }
}
