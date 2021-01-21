using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Task3
    {
        public int Stor { get; set; }
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }
        public double X3 { get; set; }
        public double Y3 { get; set; }
        public double X4 { get; set; }
        public double Y4 { get; set; }
        public int[,] kvadrat;
        public void Input()
        {
            Console.WriteLine("Введите сторону квадрата ");
            Stor = Convert.ToInt32(Console.ReadLine());
            kvadrat = new int[Stor*1000, Stor*1000];
            int st_min = Stor;
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
            int count = 0;
            for (int i=0;i<kvadrat.GetLength(0);i++)
                for (int j = 0; j < kvadrat.GetLength(0); j++)
                {
                    if ((j - Y1 * 1000) / (Y2 * 1000 - Y1 * 1000) - (i - X1 * 1000) / (X2 * 1000 - X1 * 1000) <= 0 && (j - Y1 * 1000) / (Y2 * 1000 - Y1 * 1000) - (i - X1 * 1000) / (X2 * 1000 - X1 * 1000) > 0)
                        count++;
                }
            //Console.Write("Введите количество вершин: ");
            //int n = int.Parse(Console.ReadLine());
            //var coord = new int[2, n];
            //Console.WriteLine("***Кординаты вершины вводить через пробел***");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Введите координаты вершины {0}: ", i + 1);
            //    var input = Console.ReadLine().Split(' ');
            //    coord[0, i] = int.Parse(input[0]);
            //    coord[1, i] = int.Parse(input[1]);
            //}
            //return coord;
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
