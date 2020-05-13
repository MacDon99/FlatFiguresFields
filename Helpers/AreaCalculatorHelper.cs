using System;
using FlatFiguresFields.Models.Figures;
using FlatFiguresFields.ViewModels;

namespace FlatFiguresFields.Helpers
{
    public class AreaCalculatorHelper
    {
        public string CalculateArea(Figure figure)
        {
            switch(figure.Name)
            {
                case "Rectangle": var rectangle = new Rectangle(){
                                    A = Convert.ToDouble(figure.Varriables[0]),
                                    H = Convert.ToDouble(figure.Varriables[1])
                                };
                                return CalculateGivenfigureArea(rectangle);
                case "Rhombus": var rhombus = new Rhombus(){
                                    E = Convert.ToDouble(figure.Varriables[0]),
                                    F = Convert.ToDouble(figure.Varriables[1])
                                };
                                return CalculateGivenfigureArea(rhombus);
                case "Parallelogram": var parallelogram = new Rectangle(){
                                    A = Convert.ToDouble(figure.Varriables[0]),
                                    H = Convert.ToDouble(figure.Varriables[1])
                                };
                                return CalculateGivenfigureArea(parallelogram);
                case "Square": var square = new Square(){
                                    A = Convert.ToDouble(figure.Varriables[0])
                                };
                                return CalculateGivenfigureArea(square);
                case "Triangle": var triangle = new Triangle(){
                                    A = Convert.ToDouble(figure.Varriables[0]),
                                    H = Convert.ToDouble(figure.Varriables[1])
                                };
                                return CalculateGivenfigureArea(triangle);
                case "Circle": var circle = new Circle(){
                                    R = Convert.ToDouble(figure.Varriables[0])
                                };
                                return CalculateGivenfigureArea(circle);
                case "Trapeze": var trapeze = new Trapeze(){
                                    A = Convert.ToDouble(figure.Varriables[0]),
                                    B = Convert.ToDouble(figure.Varriables[1]),
                                    H = Convert.ToDouble(figure.Varriables[2])
                                };
                                return CalculateGivenfigureArea(trapeze);
            }
            return "Error";
        }
        private string CalculateGivenfigureArea(Rectangle rectangle)
        {
            return (rectangle.A * rectangle.H).ToString();
        }
        private string CalculateGivenfigureArea(Square square)
        {
            return (square.A * square.A).ToString();
        }
        private string CalculateGivenfigureArea(Triangle triangle)
        {
            double result = (triangle.A*triangle.H)/2D;
            return result.ToString();
        }
        private string CalculateGivenfigureArea(Circle circle)
        {
            double result = circle.R*circle.R*Math.PI;
            return result.ToString();
        }
        private string CalculateGivenfigureArea(Trapeze trapeze)
        {
            double result = ((trapeze.A+trapeze.B)*trapeze.H)/2D;
            return result.ToString();
        }
        private string CalculateGivenfigureArea(Parallelogram parallelogram)
        {
            double result = (parallelogram.A * parallelogram.H);
            return result.ToString();
        }
        private string CalculateGivenfigureArea(Rhombus rhombus)
        {
            double result = (rhombus.E * rhombus.F)/2D;
            return result.ToString();
        }
    }
}