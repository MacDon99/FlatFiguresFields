using System;
using System.Collections.Generic;
using System.Linq;
using FlatFiguresFields.ViewModels;

namespace FlatFiguresFields.Services
{
    public class FigureAreaCalculator : IFigureAreaCalculator
    {
        public Figure CalculateArea(Figure figure)
        {
            figure.Varriables = figure.Values.Split(' ').ToList();

            if(!IsConversionToDoublePossible(figure.Varriables))
                {
                    figure.ErrorMessage = "Please type valid numbers (integers od decimals)";
                    return figure;
                }
            if(!ValidateVarriables(figure))
            {
                figure.ErrorMessage = "Please enter the right amount of information.";
            }
            switch(figure.Name)
            {
                case "None": figure.ErrorMessage = "Please select a figure";
                            break;
                case "Rectangle": figure.Answear = CalculateRectangleArea(figure);
                            break;
                case "Square": figure.Answear = CalculateSquareArea(figure);
                            break;
                case "Triangle": figure.Answear = CalculateTriangleArea(figure);
                            break;
                case "Circle": figure.Answear = CalculateCircleArea(figure); 
                            break;
                case "Trapeze": figure.Answear = CalculateTrapezeArea(figure); 
                            break;
                default: break;
            }
            foreach(string c in figure.Varriables)
                System.Console.WriteLine(c);


            System.Console.WriteLine();
            throw new System.NotImplementedException();
        }
        private string CalculateRectangleArea(Figure figure)
        {
            return (Convert.ToDouble(figure.Varriables[0])*Convert.ToDouble(figure.Varriables[1])).ToString();
        }
        private string CalculateSquareArea(Figure figure)
        {
            return (Convert.ToDouble(figure.Varriables[0])*Convert.ToDouble(figure.Varriables[0])).ToString();
        }
        private string CalculateTriangleArea(Figure figure)
        {
            double a = Convert.ToDouble(figure.Varriables[0]);
            double h = Convert.ToDouble(figure.Varriables[1]);
            double result = (a*h)/2D;
            return result.ToString();
        }
        private string CalculateCircleArea(Figure figure)
        {
            double r = Convert.ToDouble(figure.Varriables[0]);
            double result = r*r*Math.PI;
            return result.ToString();
        }
        private string CalculateTrapezeArea(Figure figure)
        {
            double a = Convert.ToDouble(figure.Varriables[0]);
            double b = Convert.ToDouble(figure.Varriables[1]);
            double h = Convert.ToDouble(figure.Varriables[2]);
            double result = ((a+b)*h)/2D;
            return result.ToString();
        }
        private bool IsConversionToDoublePossible(List<string> values)
        {
            foreach(var val in values)
                try
                {
                    Convert.ToDouble(val);
                }
                catch
                {
                    return false;
                }
            return true;
        }
        private bool ValidateVarriables(Figure figure)
        {
            if(figure.Name == "Rectangle" && figure.Varriables.Count == 2)
            {
                return true;
            }
            if(figure.Name == "Square" && figure.Varriables.Count == 1)
            {
                return true;
            }
            if(figure.Name == "Triangle" && figure.Varriables.Count == 2)
            {
                return true;
            }
            if(figure.Name == "Circle" && figure.Varriables.Count == 1)
            {
                return true;
            }
            if(figure.Name == "Trapeze" && figure.Varriables.Count == 3)
            {
                return true;
            }
            return false;
        }
    }
}