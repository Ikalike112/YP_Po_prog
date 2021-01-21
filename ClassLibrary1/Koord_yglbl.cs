using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public class Koord_yglbl
    {
        public int kol = 0;
        int pol_X1 = -10;
        int pol_X2 = -10;
        int pol_Y1 = 10;
        int pol_Y2 = 10;
        Random r = new Random();
        public static int Kol_dots = 100;
        public List<Dot2D> dots = new List<Dot2D>();
        public List<Dot2D> dots_X = new List<Dot2D>();
        public List<Dot2D> dots_Y = new List<Dot2D>();
        public List<Dot2D> dots_Z = new List<Dot2D>();      
        public List<Triangle> Answer = new List<Triangle>();      
        /// <summary>
        /// Constructor 
        /// </summary>
        public Koord_yglbl()
        {
            GenerateDots();
            KolvoDotsInXYZ();
            Vivod_Triangle();
        }
        /// <summary>
        /// Vivod treygolnikov i ix plowadi
        /// </summary>
        private void Vivod_Triangle()
        {
            foreach(var it in Answer)
            {
                Console.WriteLine($"Треугольник со сторонами {it.A} {it.B} {it.C} имеет площадь {it.S}, его точки {it.X.ToString()} {it.Y.ToString()} {it.Z.ToString()}");
            }
        }
        /// <summary>
        /// Poisk neobxodimix Triangle
        /// </summary>
        private void KolvoDotsInXYZ()
        {
            foreach (var it in dots)
            {
                if (it.X > 0 && it.Y > 0)
                    dots_X.Add(it);
                else
                if (it.X < 0 && it.Y > 0)
                    dots_Y.Add(it);
                else
                if (it.X < 0 && it.Y < 0)
                    dots_Z.Add(it);
            }
            double p;
            double S;
            double A;
            double B;
            double C;

            foreach (var it_X in dots_X)
                foreach (var it_Y in dots_Y)
                    foreach (var it_Z in dots_Z)
                    {
                         A = GetSide(it_X.X, it_X.Y, it_Y.X, it_Y.Y);
                         B = GetSide(it_Y.X, it_Y.Y, it_Y.X, it_X.Y);
                         C = GetSide(it_Z.X, it_Z.Y, it_X.X, it_X.Y);
                        p = (A+B + C) / 2;
                        S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
                        if (S < 5)
                            Answer.Add(new Triangle(A,B,C,S, it_X, it_Y,it_Z));
                            
                    }
        }
        /// <summary>
        /// расстояние между двумя точками
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns>double</returns>
        static double GetSide(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        /// <summary>
        /// Генерация точек рандомно учитывая текущее время
        /// </summary>
        private void GenerateDots()
        {
            int x;
            int y;
            for (int i = 0; i < Kol_dots; i++)
            {
                x = r.Next(pol_X1, pol_Y1);
                r = new Random(i * System.DateTime.Now.Second);
                y = r.Next(pol_X1, pol_Y2);
                dots.Add(new Dot2D(x, y));
            }
        }
    }
}
