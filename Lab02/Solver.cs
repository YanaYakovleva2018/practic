using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    /// <summary>
    /// Класс выполняющий вычисление корней квадратного уранения
    /// </summary>
    public class Solver
    {
        /// <summary>
        /// Метод класса, отвечающий за вычисления
        /// </summary>
        /// <param name="a">Первый коэфциент уравнения</param>
        /// <param name="b">Второй коэфициент уравнения</param>
        /// <param name="c">Третий коэфициент уравнения</param>
        /// <returns>Массив строковых представлений корней</returns>
        public string[] Result(double a, double b, double c)
        {
            double D, X1, X2;
            string[] res = new string[2];
            D = b * b - 4 * a * c;
            if (D >= 0)
            {
                X1 = (-1 * b + Math.Sqrt(D)) / (2 * a);
                X2 = (-1 * b - Math.Sqrt(D)) / (2 * a);
                res[0] = X1.ToString("F4");
                res[1] = X2.ToString("F4");
                return res;
            }
            else
            {

                res[0] = (-1 * b / (2 * a)).ToString("F4") + "+" +
                    (Math.Sqrt(-1 * D) / (2 * a)).ToString("F4") + "i";
                res[1] = (-1 * b / (2 * a)).ToString("F4") + "-" +
                    (Math.Sqrt(-1 * D) /( 2 * a)).ToString("F4") + "i";
                return res;
            }
        }
    }
}
