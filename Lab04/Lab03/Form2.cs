using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    /// <summary>
    /// Класс формы с результатами обработки матрицы
    /// </summary>
    public partial class Form2 : Form
    {
        /// <summary>
        /// Поле для хранение обрабатываемой матрицы
        /// </summary>
        public Matrix NewMatrix;
        public Form2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработчик события появления формы, выводящий на неё результаты обработки матрицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Shown(object sender, EventArgs e)
        {
            NewMatrix.SortRows();
            NewMatrix.MinElement();
            NewMatrix.Centre();
            DgvOrigin.RowCount = NewMatrix.sizeSide;
            DgvOrigin.ColumnCount = NewMatrix.sizeSide;
            for (int i = 0; i < NewMatrix.sizeSide; i++)
            {
                for (int j = 0; j < NewMatrix.sizeSide; j++)
                {
                    DgvOrigin[i, j].Value = NewMatrix.mat[j,i];
                    DgvOrigin[i, j].OwningRow.Height = 25;
                    DgvOrigin[i, j].OwningColumn.Width = 50;
                    DgvOrigin.Columns[i].DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleCenter;
                }
            }
            DgvSort.RowCount = NewMatrix.sizeSide;
            DgvSort.ColumnCount = NewMatrix.sizeSide;
            for (int i = 0; i < NewMatrix.sizeSide; i++)
            {
                for (int j = 0; j < NewMatrix.sizeSide; j++)
                {
                    DgvSort[i,j].Value = NewMatrix.sortedMatr[j,i];
                    DgvSort[i, j].OwningRow.Height = 25;
                    DgvSort[i, j].OwningColumn.Width = 50;
                    DgvSort.Columns[i].DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleCenter;
                }
            }
            DgvCentre.RowCount = NewMatrix.sizeSide;
            DgvCentre.ColumnCount = NewMatrix.sizeSide;
            for (int i = 0; i < NewMatrix.sizeSide; i++)
            {
                for (int j = 0; j < NewMatrix.sizeSide; j++)
                {
                    DgvCentre[i, j].Value = NewMatrix.centreMatr[j,i];
                    DgvCentre[i, j].OwningRow.Height = 25;
                    DgvCentre[i, j].OwningColumn.Width = 60;
                    DgvCentre.Columns[i].DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleCenter;
                }
            }
            Least.Text = "Наименьший элемент с чётной суммой индексов - " + NewMatrix.minElem.ToString();
        }
    }
}
