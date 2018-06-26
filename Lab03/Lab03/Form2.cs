using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    /// <summary>
    /// Класс формы с результатами обработки массива
    /// </summary>
    public partial class Form2 : Form
    {
        /// <summary>
        /// Поле для хранение обрабатываемого массива
        /// </summary>
        public Array NewArray;
        public Form2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработчик события появления формы, выводящий на неё результаты обработки массива
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Shown(object sender, EventArgs e)
        {
            string reverse ="";
            NewArray.ReverseArray();
            for (int i = 0; i < NewArray.arr.Length; i++)
            {
                reverse += NewArray.rev_arr[i].ToString() + " ";
            }
            textBox1.Text = reverse;
            NewArray.LastDigitSummCount();
            Summ.Text = NewArray.lastdigitsum.ToString();
            Number.Text = NewArray.lastdigitcount.ToString();
            NewArray.SimpleCount();
            Simple.Text = NewArray.num_simple.ToString();
            NewArray.RangeStatistic();
            Statistic.Text = NewArray.statistic;
        }
    }
}
