using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        /// <summary>
        /// Обработчик, отвечающий за ввод в поле первого коэфициента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextA_KeyPress(object sender, KeyPressEventArgs e)
        {
            Error.Text = "";
            string pattern = @"^[\+-]{0,1}[0-9]{0,3}(,[0-9]{0,3})?$";
            string number = TextA.Text + e.KeyChar;
            if (e.KeyChar == (char)Keys.Back)
            {
                    if (TextA.SelectionStart > 1)
                    {
                        TextA.Select(TextA.SelectionStart, 0);
                    }
            }
            else
            {
                if (!Regex.IsMatch(number, pattern))
                {
                    e.KeyChar = (char)Keys.None;
                }
            }
        }
        /// <summary>
        /// Контроль клавиши Delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                TextA.Text = "";
            }
        }
        /// <summary>
        /// Кнопка, очищающая все поля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_Click(object sender, EventArgs e)
        {
            TextB.Text = "";
            TextA.Text = "";
            TextC.Text = "";
            TextX1.Text = "";
            TextX2.Text = "";
        }
        /// <summary>
        /// Контроль клавиши Delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                TextC.Text = "";
            }

        }

        /// <summary>
        /// Обработчик, отвечающий за ввод в поле третьего коэфициента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextC_KeyPress(object sender, KeyPressEventArgs e)
        {
            Error.Text = "";
            string pattern = @"^[\+-]{0,1}[0-9]{0,3}(,[0-9]{0,3})?$";
            string number = TextC.Text + e.KeyChar;
            if (e.KeyChar == (char)Keys.Back)
            {
                if (TextC.SelectionStart > 1)
                {
                    TextC.Select(TextC.SelectionStart, 0);
                }
            }
            else
            {
                if (!Regex.IsMatch(number, pattern))
                {
                    e.KeyChar = (char)Keys.None;
                }
            }

        }
        /// <summary>
        /// Контроль клавиши Delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                TextB.Text = "";
            }

        }

        /// <summary>
        /// Обработчик, отвечающий за ввод в поле первого коэфициента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextB_KeyPress(object sender, KeyPressEventArgs e)
        {
            Error.Text = "";
            string pattern = @"^[\+-]{0,1}[0-9]{0,3}(,[0-9]{0,3})?$";
            string number = TextB.Text + e.KeyChar;
            if (e.KeyChar == (char)Keys.Back)
            {
                if (TextB.SelectionStart > 1)
                {
                    TextB.Select(TextB.SelectionStart, 0);
                }
            }
            else
            {
                if (!Regex.IsMatch(number, pattern))
                {
                    e.KeyChar = (char)Keys.None;
                }
            }

        }
        /// <summary>
        /// Вызываемый метод, для вычисления корней уравнения
        /// </summary>
        /// <param name="a">Первый коэфициент</param>
        /// <param name="b">Второй коэфициент</param>
        /// <param name="c">Третий коэфициент</param>
        /// <returns>Массив строковых предсталений корней уравнения</returns>
        public static string[] Resoulution(double a, double b, double c)
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
                    (Math.Sqrt(-1 * D) / (2 * a)).ToString("F4") + "i";
                return res;
            }
        }
        /// <summary>
        /// Вычисления корней в обработчике
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InHandler_Click(object sender, EventArgs e)
        {
            if (TextA.Text != "" && TextB.Text != "" && TextC.Text != "" &&
                TextA.Text != "-" && TextB.Text != "-" && TextC.Text != "-" &&
                TextA.Text != "+" && TextB.Text != "+" && TextC.Text != "+" &&
                TextA.Text != "," && TextB.Text != "," && TextC.Text != ",")
            {
                double D, X1, X2, a, b, c;
                a = double.Parse(TextA.Text);
                b = double.Parse(TextB.Text);
                c = double.Parse(TextC.Text);
                D = b * b - 4 * a * c;
                if (D >= 0)
                {
                    X1 = (-1 * b + Math.Sqrt(D)) / (2 * a);
                    X2 = (-1 * b - Math.Sqrt(D)) / (2 * a);
                    TextX1.Text = X1.ToString("F4");
                    TextX2.Text = X2.ToString("F4");
                }
                else
                {
                    string comp_x1, comp_x2;
                    comp_x1 = (-1  *b / (2 * a)).ToString("F4") + "+" +
                        (Math.Sqrt(-1 * D) / (2 * a)).ToString("F4") + "i";
                    comp_x2 = (-1*b/ (2 * a)).ToString("F4") + "-" +
                        (Math.Sqrt(-1 * D) / (2 * a)).ToString("F4") + "i";
                    TextX1.Text = comp_x1;
                    TextX2.Text = comp_x2;
                }
            }
            else 
            {
                Error.Text = "Ошибка, не все поля заполнены! \nЛибо неверный формат вводимых данных!";
            }
        }
        /// <summary>
        /// Вычисление корней в методе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InMethod_Click(object sender, EventArgs e)
        {
            if (TextA.Text != "" && TextB.Text != "" && TextC.Text != "" &&
                TextA.Text != "-" && TextB.Text != "-" && TextC.Text != "-" &&
                TextA.Text != "+" && TextB.Text != "+" && TextC.Text != "+" &&
                TextA.Text != "," && TextB.Text != "," && TextC.Text != ",")
            {
                double a, b, c;
                string[] res = new string[2];
                a = double.Parse(TextA.Text);
                b = double.Parse(TextB.Text);
                c = double.Parse(TextC.Text);
                res = Form1.Resoulution(a, b, c);
                TextX1.Text = res[0];
                TextX2.Text = res[1];
            }
            else
            {
                Error.Text = "Ошибка, не все поля заполнены! \nЛибо неверный формат вводимых данных!";
            }
        }
        /// <summary>
        /// Вычисление корней в отдельном классе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InClass_Click(object sender, EventArgs e)
        {
            if (TextA.Text != "" && TextB.Text != "" && TextC.Text != ""&&
                TextA.Text != "-" && TextB.Text != "-" && TextC.Text != "-"&&
                TextA.Text != "+" && TextB.Text != "+" && TextC.Text != "+"&&
                TextA.Text != "," && TextB.Text != "," && TextC.Text != ",")
            {
                double a, b, c;
                string[] res = new string[2];
                Solver Worker = new Solver();
                a = double.Parse(TextA.Text);
                b = double.Parse(TextB.Text);
                c = double.Parse(TextC.Text);
                res = Worker.Result(a, b, c);
                TextX1.Text = res[0];
                TextX2.Text = res[1];
            }
            else
            {
                Error.Text = "Ошибка, не все поля заполнены! \nЛибо неверный формат вводимых данных!";
            }
        }
        /// <summary>
        /// Кнопка, для закрытия программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
