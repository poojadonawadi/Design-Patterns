using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patttern_Practice
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }

    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }
}
