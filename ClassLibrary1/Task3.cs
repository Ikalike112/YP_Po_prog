using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Task3
    {
        public double Stor { get; set; }
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }
        public double X3 { get; set; }
        public double Y3 { get; set; }
        public double X4 { get; set; }
        public double Y4 { get; set; }
        public int[,] kvadrat;
        public void Task()
        {
            Input();
            kvadrat = new int[1000, 1000];
            double st_min = Stor / 1000;//0.005
            Vichislenia(st_min);
        }

        public void Input()
        {
            Console.WriteLine("Введите сторону квадрата ");
            Stor = Convert.ToDouble(Console.ReadLine());//5
            Console.WriteLine("Введите координаты прямой X1 Y1");
            X1 = Convert.ToDouble(Console.ReadLine());
            Y1 = Convert.ToDouble(Console.ReadLine());
            X2 = Convert.ToDouble(Console.ReadLine());
            Y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты прямой X2 Y2");
            X3 = Convert.ToDouble(Console.ReadLine());
            Y3 = Convert.ToDouble(Console.ReadLine());
            X4 = Convert.ToDouble(Console.ReadLine());
            Y4 = Convert.ToDouble(Console.ReadLine());
        }

        public void Vichislenia(double st_min)
        {
            int count_pl1 = 0;
            int count_pl2 = 0;
            int count_pl3 = 0;
            for (int i = 0; i < kvadrat.GetLength(0); i++)
                for (int j = 0; j < kvadrat.GetLength(1); j++)
                {
                    if ((st_min * j - Y1) / (Y2 - Y1) <= (st_min * i - X1) / (X2 - X1) && (st_min * j - Y3) / (Y4 - Y3) <= (st_min * i - X3) / (X4 - X3)) count_pl1++;
                    if ((st_min * j - Y1) / (Y2 - Y1) >= (st_min * i - X1) / (X2 - X1) && (st_min * j - Y3) / (Y4 - Y3) <= (st_min * i - X3) / (X4 - X3)) count_pl2++;
                    if ((st_min * j - Y1) / (Y2 - Y1) >= (st_min * i - X1) / (X2 - X1) && (st_min * j - Y3) / (Y4 - Y3) >= (st_min * i - X3) / (X4 - X3)) count_pl3++;
                    // if ((j - Y1 * 1000) / (Y2 * 1000 - Y1 * 1000) - (i - X1 * 1000) / (X2 * 1000 - X1 * 1000) <= 0 && (j - Y1 * 1000) / (Y2 * 1000 - Y1 * 1000) - (i - X1 * 1000) / (X2 * 1000 - X1 * 1000) > 0)
                    //    count++;
                }
            Console.WriteLine($"Pl1 = {count_pl1 * Stor * Stor / 1000000}");
            Console.WriteLine($"Pl2 = {count_pl2 * Stor * Stor / 1000000}");
            Console.WriteLine($"Pl3 = {count_pl3 * Stor * Stor / 1000000}");
        }

        static double Area(int[,] coord)
        {
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < coord.GetLength(1) - 1; i++)
            {
                sum1 += coord[0, i] * coord[1, i + 1];
                sum2 += coord[1, i] * coord[0, i + 1];
            }

            return Math.Abs((sum1 - sum2) / 2d);
        }
        //static void Main(string[] args)
        //{
        //    int[,] coord = Input();
        //    var area = Area(coord);
        //    Console.WriteLine("Пложадь многоугольника равна {0}", area);
        //    Console.ReadKey();
        //}

    }
}
