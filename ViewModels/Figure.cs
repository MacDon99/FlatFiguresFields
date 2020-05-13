using System.Collections.Generic;

namespace FlatFiguresFields.ViewModels
{
    public class Figure
    {
        public string Name { get; set; }
        public string Values { get; set; }
        public List<string> Varriables { get; set; }
        public Figure()
        {
            Varriables = new List<string>();
        }
    }
}