using System;
using System.Collections.Generic;
using System.Linq;
using FlatFiguresFields.Helpers;
using FlatFiguresFields.Models.Figures;
using FlatFiguresFields.ViewModels;

namespace FlatFiguresFields.Services
{
    public class FigureAreaCalculator : IFigureAreaCalculator
    {
        private readonly AreaCalculatorHelper _calculatorHelper;
        public FigureAreaCalculator(AreaCalculatorHelper calculatorHelper)
        {
            _calculatorHelper = calculatorHelper;
        }
        public Figure CalculateArea(Figure figure)
        {
            figure = CheckFigureRequest(figure);

            if(figure.ErrorMessage != null)
                return figure;

            figure.Answear = _calculatorHelper.CalculateArea(figure);
            return figure;
        }
        private bool IsConversionToDoublePossible(List<string> values)
        {
            foreach(var val in values)
            {
                try
                {
                    Convert.ToDouble(val);
                }
                catch
                {
                    return false;
                }
                if(Convert.ToDouble(val)<0)
                {
                    return false;
                }
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
            if(figure.Name == "Trapeze" && figure.Varriables.Count == 3 )
            {
                return true;
            }
            if(figure.Name == "Parallelogram" && figure.Varriables.Count == 2)
            {
                return true;
            }
            if(figure.Name == "Rhombus" && figure.Varriables.Count == 2)
            {
                return true;
            }
            return false;
        }

        private Figure CheckFigureRequest(Figure figure)
        {
            if(figure.Values == null)
                {
                    figure.ErrorMessage = "Please enter the required data.";
                    return figure;
                }
            figure.Varriables = figure.Values.Trim().Replace('.', ',').Split(' ').ToList();

            if(!IsConversionToDoublePossible(figure.Varriables))
                {
                    figure.ErrorMessage = "Please type valid numbers (integers od decimals)";
                }
            if(!ValidateVarriables(figure))
            {
                figure.ErrorMessage = "Please enter the right amount of information.";
            }
            return figure;
        }
        
    }
}