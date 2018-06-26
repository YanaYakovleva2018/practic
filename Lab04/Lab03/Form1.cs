using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab04
{
    /// <summary>
    /// Класс основной формы проекта
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Обьект с основной функциональностью
        /// </summary>
        Matrix NewMatrix = new Matrix();
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Открытие файла с матрицей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenButton_Click(object sender, EventArgs e)
        {
            ResultButton.Enabled = true;
            SaveButton.Enabled = true;
            string fname = ""; ;
            Open.InitialDirectory = "D:\\";
            Open.Filter = "txt files(*.txt)|*.txt";
            Open.FilterIndex = 1;
            try{
                if (Open.ShowDialog() == DialogResult.OK)
                {
                    fname = Open.FileName;
                    NewMatrix.LoadArray(fname);
                    Dgv.RowCount = NewMatrix.sizeSide;
                    Dgv.ColumnCount = NewMatrix.sizeSide;
                    for (int i = 0; i < NewMatrix.sizeSide; i++)
                    {
                        for (int j = 0; j < NewMatrix.sizeSide; j++)
                        {
                            Dgv[i, j].Value = NewMatrix.mat[j,i];
                            Dgv[i, j].OwningRow.Height = 25;
                            Dgv[i, j].OwningColumn.Width = 50;
                            Dgv.Columns[i].DefaultCellStyle.Alignment =
                                DataGridViewContentAlignment.MiddleCenter;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Это не файл с массивом!!!","Ошибка!!!");
            }
            

        }
        /// <summary>
        /// Сохранение мастрицы в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string fname;
            Save.InitialDirectory = "D:\\";
            Save.Filter = "txt files(*.txt)|*.txt";
            Save.FilterIndex = 1;
            if (Save.ShowDialog() == DialogResult.OK)
            {
                fname = Save.FileName;
                NewMatrix.SaveArray(fname);
               
            }
        }
        /// <summary>
        /// Контроль верхней границы установки минимума
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArrMin_ValueChanged(object sender, EventArgs e)
        {
            ArrMax.Minimum = (int)ArrMin.Value + 1;
        }
        /// <summary>
        /// Контрль нижней границы установки максимума
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArrMax_ValueChanged(object sender, EventArgs e)
        {
            ArrMin.Maximum = (int)ArrMax.Value - 1;
        }
        /// <summary>
        /// Генерация матрицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Generate_Click(object sender, EventArgs e)
        {
            ResultButton.Enabled = true;
            SaveButton.Enabled = true;
            NewMatrix.Generate((int)ArrSize.Value,(int)ArrMax.Value,(int)ArrMin.Value);
            Dgv.RowCount = NewMatrix.sizeSide;
            Dgv.ColumnCount = NewMatrix.sizeSide;
            for (int i = 0; i < NewMatrix.sizeSide; i++)
            {
                for (int j = 0; j < NewMatrix.sizeSide; j++)
                {
                    Dgv[i, j].Value = NewMatrix.mat[j,i];
                    Dgv[i, j].OwningRow.Height = 25;
                    Dgv[i, j].OwningColumn.Width = 50;
                    Dgv.Columns[i].DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }
        /// <summary>
        /// Установка параметров некоторых елементов управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Shown(object sender, EventArgs e)
        {
            Dgv.RowCount = 1;
            Dgv.ColumnCount = 1;
            Dgv[0, 0].OwningRow.Height = 25;
            Dgv[0, 0].OwningColumn.Width = 50;
        }
        /// <summary>
        /// Вызов формы с результатами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResultButton_Click(object sender, EventArgs e)
        {
            Form2 ResForm = new Form2();
            SaveRes.Enabled = true;
            ResForm.NewMatrix = NewMatrix;
            ResForm.Show();
        }
        /// <summary>
        /// Открытие файла с результатами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenRes_Click(object sender, EventArgs e)
        {
            ResultButton.Enabled = true;
            SaveButton.Enabled = true;
            SaveRes.Enabled = true;
            string fname = ""; ;
            Open.InitialDirectory = "D:\\";
            Open.Filter = "txt files(*.txt)|*.txt";
            Open.FilterIndex = 1;
            try
            {
                if (Open.ShowDialog() == DialogResult.OK)
                {
                    fname = Open.FileName;
                    NewMatrix.LoadResult(fname);
                    Dgv.RowCount = NewMatrix.sizeSide;
                    Dgv.ColumnCount = NewMatrix.sizeSide;
                    for (int i = 0; i < NewMatrix.sizeSide; i++)
                    {
                        for (int j = 0; j < NewMatrix.sizeSide; j++)
                        {
                            Dgv[i, j].Value = NewMatrix.mat[j,i];
                            Dgv[i, j].OwningRow.Height = 25;
                            Dgv[i, j].OwningColumn.Width = 50;
                            Dgv.Columns[i].DefaultCellStyle.Alignment =
                                DataGridViewContentAlignment.MiddleCenter;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Это не файл с результатами!!!", "Ошибка!!!");
            }
        }
        /// <summary>
        /// Сохранение результатов в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveRes_Click(object sender, EventArgs e)
        {
            string fname;
            Save.InitialDirectory = "D:\\";
            Save.Filter = "txt files(*.txt)|*.txt";
            Save.FilterIndex = 1;
            if (Save.ShowDialog() == DialogResult.OK)
            {
                fname = Save.FileName;
                NewMatrix.SaveResult(fname);

            }
        }
        /// <summary>
        /// Вызов формы с информацией о авторе проекта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Author_Click(object sender, EventArgs e)
        {
            Form3 Author = new Form3();
            Author.ShowDialog();
        }

        
    }
}
