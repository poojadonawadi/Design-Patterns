using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patttern_Practice
{
    internal class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            else if(shapeType == "Circle")
            {
                return new Circle();
            }
            else if (shapeType == "Rectangle")
            {
                return new Rectangle();
            }
            return null;
        }
    }
}
