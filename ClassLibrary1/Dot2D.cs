using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Dot2D
    {
        public int X { private set; get; }
        public int Y { private set; get; }
        /// <summary>
        /// Пустой конструктор
        /// </summary>
        public Dot2D()
        {

        }
        /// <summary>
        /// Конструктор точки с ее координатами
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Dot2D(int x, int y)
        {
            X = x;
            Y = y;
        }
        /// <summary>
        /// Перегрузка ToString возвращающая координаты 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "X: " + X + " Y: " + Y;
        }
    }
}
