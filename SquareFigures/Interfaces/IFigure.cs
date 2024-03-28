namespace SquareFigures.Interfaces;

/// <summary>
/// Родительский класс фигуры 
/// (позволяет легко добавить новую)
/// </summary>
public interface IFigure
{
    /// <summary>
    /// Метод, считающий площадь фигуры
    /// </summary>
    /// <returns>Площадь фигуры</returns>
    double CalculateSquare();
}
