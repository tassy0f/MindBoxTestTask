using SquareFigures.Interfaces;

namespace SquareFigures;

/// <summary>
///  Библиотека, вычесляющая площадь круга по его радиусу и площадь треугольника по его трем сторонам.
/// </summary>
public class SquareCalculate
{
    public double CalculateSquare(IFigure figure)
    {
        return figure.CalculateSquare();
    }
}

/// <summary>
/// Круг
/// </summary>
public class Circle : IFigure
{
    /// <summary>
    /// Радиус круга
    /// </summary>
    private double circleRadius;

    public Circle(double radius)
    {
        this.circleRadius = radius;
    }

    /// <summary>
    /// Вычисление площади круга
    /// </summary>
    /// <returns>Площадь круга</returns>
    public double CalculateSquare()
    {
        return Math.PI * circleRadius * circleRadius;
    }
}

/// <summary>
/// Треугольник
/// </summary>
public class Triangle : IFigure
{
    /// <summary>
    /// Три стороны треугольника
    /// </summary>
    private double sideA, sideB, sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    /// <summary>
    /// Вычесление площади по его сторонам
    /// </summary>
    /// <returns>Площадь треугольника</returns>
    public double CalculateSquare()
    {
        double halfOfPerimeter = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - sideA) * (halfOfPerimeter - sideB) * (halfOfPerimeter - sideC));
    }

    /// <summary>
    /// Проверка на треугольник при помощи теоремы Пифагора
    /// </summary>
    /// <returns></returns>
    public bool IsTriangle()
    {
        double[] sides = { sideA, sideB, sideC };
        Array.Sort(sides);
        return sides[2] * sides[2] == sides[0] * sides[0] + sides[1] * sides[1];
    }
}