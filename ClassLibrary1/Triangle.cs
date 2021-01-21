using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Triangle
    {
        public double A { private set; get; }
        public double B { private set; get; }
        public double C { private set; get; }
        public double S { private set; get; }
        public Dot2D X { private set; get; }
        public Dot2D Y { private set; get; }
        public Dot2D Z { private set; get; }
        /// <summary>
        /// пустой конструктор
        /// </summary>
        public Triangle()
        {

        }
        /// <summary>
        /// конструктор первые 3 переменные - длины сторон далее площадь и 3 координаты этих точек
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="s"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Triangle(double a, double b, double c, double s, Dot2D x, Dot2D y, Dot2D z)
        {
            A = a;
            B = b;
            C = c;
            S = s;
            X = x;
            Y = y;
            Z = z;

        }
        public Triangle(double a, double b, double c, double s)
        {
            A = a;
            B = b;
            C = c;
            S = s;

        }
    }
}
