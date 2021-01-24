using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            Pole p;
            while (true)
            {
                Console.WriteLine("1 Дано множество точек на плоскости. Сколько точек этого множества окажутся внутри круга," +
                    "ограниченного окружностью с центром в первой точке этого множества и радиусом, являющимся самым большим расстоянием" +
                    " между двумя точками?");
                Console.WriteLine("2 Дано множество точек на плоскости. Указать три точки X, Y, Z так, чтобы X находилась в 1-ом координатном углу," +
                    " Y находилась во 2-ом координатном углу, Z находилась в 3-ем координатном углу и треугольник XYZ имел площадь, меньшую 5 кв. ед.");

                switch (c=int.Parse(Console.ReadLine()))
                {
                    case 1:
                        p = new Pole();
                        Console.WriteLine($"Количество точек равно {p.kol}");
                        break;
                    case 2:
                        Koord_yglbl task2 = new Koord_yglbl();
                        break;
                    case 3:
                        Task3 t = new Task3();
                        t.Input();
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
