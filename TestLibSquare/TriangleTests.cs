using NUnit;
using SquareFigures;

namespace TestLibSquare;

[TestFixture]
public class TriangleTests
{
    [Test]
    public void TestCalculateArea_WithSides3_4_5_ReturnsCorrectArea()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        var triangle = new Triangle(sideA, sideB, sideC);

        // Act
        double area = triangle.CalculateSquare();

        // Assert
        Assert.AreEqual(6, area);
    }

    [Test]
    public void TestIsRightTriangle_WithSides3_4_5_ReturnsTrue()
    {
        // Arrange
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        var triangle = new Triangle(sideA, sideB, sideC);

        // Act
        bool isRightTriangle = triangle.IsTriangle();

        // Assert
        Assert.IsTrue(isRightTriangle);
    }

    [Test]
    public void TestIsRightTriangle_WithSides5_12_13_ReturnsTrue()
    {
        // Arrange
        double sideA = 5;
        double sideB = 12;
        double sideC = 13;
        var triangle = new Triangle(sideA, sideB, sideC);

        // Act
        bool isRightTriangle = triangle.IsTriangle();

        // Assert
        Assert.IsTrue(isRightTriangle);
    }

    [Test]
    public void TestIsRightTriangle_WithSides6_8_10_ReturnsFalse()
    {
        // Arrange
        double sideA = 6;
        double sideB = 8;
        double sideC = 10;
        var triangle = new Triangle(sideA, sideB, sideC);

        // Act
        bool isRightTriangle = triangle.IsTriangle();

        // Assert
        Assert.IsFalse(isRightTriangle);
    }
}
