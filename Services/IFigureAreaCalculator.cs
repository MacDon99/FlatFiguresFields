using FlatFiguresFields.ViewModels;

namespace FlatFiguresFields.Services
{
    public interface IFigureAreaCalculator
    {
        Figure CalculateArea(Figure figure);
    }
}