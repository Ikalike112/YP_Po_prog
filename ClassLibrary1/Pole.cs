using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Pole
    {
        public int kol = 0;
        int pol_X1 = -100;
        int pol_X2 = -100;
        int pol_Y1 = 100;
        int pol_Y2 = 100;
        Random r = new Random();
        public static int Kol_dots = 100;
        public List<Dot2D> dots =new List<Dot2D>();
        public Pole()
        {
            GenerateDots();
            double rad = FindRadius();
            KolvoDotsInCircle(rad);
        }
        /// <summary>
        /// Поиск количества точек в радиусе круга
        /// </summary>
        /// <param name="rad"></param>
        private void KolvoDotsInCircle(double rad)
        {
            foreach (var it in dots)
                if (Math.Sqrt(Math.Pow(it.X - dots[0].X, 2) + Math.Pow(it.Y - dots[0].Y, 2)) < rad)
                    kol++;
        }
        /// <summary>
        /// Функция нахождения радиуса
        /// </summary>
        /// <returns>double</returns>
        private double FindRadius()
        {
            double rad = 0;
            double tmp = 0;
            foreach (var it in dots)
                foreach (var it1 in dots)
                {
                    tmp = Math.Sqrt(Math.Pow(it1.X - it.X, 2) + Math.Pow(it1.Y - it.Y, 2));
                    if (tmp > rad /*> tmp !=0*/)
                        rad = tmp;
                }

            return rad;
        }
        /// <summary>
        /// Функция генерации точек
        /// </summary>
        private void GenerateDots()
        {
            int x;
            int y;
            for (int i = 0; i < Kol_dots; i++)
            {
                x = r.Next(pol_X1, pol_Y1);
                r = new Random(i*System.DateTime.Now.Second);
                y = r.Next(pol_X1, pol_Y2);
                dots.Add(new Dot2D(x, y));
            }
        }
    }
}
