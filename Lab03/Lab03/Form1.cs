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

namespace Lab03
{
    /// <summary>
    /// Класс основной формы проекта
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Обьект с основной функциональностью
        /// </summary>
        Array NewArr = new Array();
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Открытие файла с массивом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenButton_Click(object sender, EventArgs e)
        {
            ResultButton.Enabled = true;
            SaveButton.Enabled = true;
            string fname, output = ""; ;
            Open.InitialDirectory = "D:\\";
            Open.Filter = "xml files(*.xml)|*.xml";
            Open.FilterIndex = 1;
            try{
                if (Open.ShowDialog() == DialogResult.OK)
                {
                    fname = Open.FileName;
                    NewArr.LoadArray(fname);
                    Dgv.RowCount = NewArr.arr.Length;
                    for (int i = 0; i < NewArr.arr.Length; i++)
                    {
                        output += NewArr.arr[i].ToString() + " ";
                        Dgv[0, i].Value = i;
                        Dgv[1, i].Value = NewArr.arr[i];
                    }
                    TextBox.Text = output;
                }}
            catch(System.InvalidOperationException ex)
            {
                MessageBox.Show("Это не файл с массивом!!!","Ошибка!!!");
            }
            

        }
        /// <summary>
        /// Сохранение массива в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string fname;
            Save.InitialDirectory = "D:\\";
            Save.Filter = "xml files(*.xml)|*.xml";
            Save.FilterIndex = 1;
            if (Save.ShowDialog() == DialogResult.OK)
            {
                fname = Save.FileName;
                NewArr.SaveArray(fname);
               
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
        /// Генерация массива
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Generate_Click(object sender, EventArgs e)
        {
            ResultButton.Enabled = true;
            SaveButton.Enabled = true;
            string output = "";
            NewArr.Generate((int)ArrSize.Value,(int)ArrMax.Value,(int)ArrMin.Value);
            Dgv.RowCount = NewArr.arr.Length;
            for (int i = 0; i < NewArr.arr.Length; i++)
            {
                output += NewArr.arr[i].ToString() + " ";
                Dgv[0,i].Value = i;
                Dgv[1,i].Value = NewArr.arr[i];
            }
            TextBox.Text = output;
            

        }
        /// <summary>
        /// Установка параметров некоторых елементов управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Shown(object sender, EventArgs e)
        {
            Dgv.ColumnCount = 2;
            Dgv.RowCount = 1;
            Dgv.Columns[0].HeaderText = "i";
            Dgv.Columns[1].HeaderText = "Array[i]";
            Dgv.Columns[0].DefaultCellStyle.Alignment = 
                DataGridViewContentAlignment.MiddleCenter;
            Dgv.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
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
            ResForm.NewArray = NewArr;
            ResForm.Show();
        }
        /// <summary>
        /// Открытие формы с результатами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenRes_Click(object sender, EventArgs e)
        {
            ResultButton.Enabled = true;
            SaveButton.Enabled = true;
            SaveRes.Enabled = true;
            string fname, output = ""; ;
            Open.InitialDirectory = "D:\\";
            Open.Filter = "xml files(*.xml)|*.xml";
            Open.FilterIndex = 1;
            try
            {
                if (Open.ShowDialog() == DialogResult.OK)
                {
                    fname = Open.FileName;
                    NewArr.LoadResult(fname);
                    Dgv.RowCount = NewArr.arr.Length;
                    for (int i = 0; i < NewArr.arr.Length; i++)
                    {
                        output += NewArr.arr[i].ToString() + " ";
                        Dgv[0, i].Value = i;
                        Dgv[1, i].Value = NewArr.arr[i];
                    }
                    TextBox.Text = output;
                }
            }
            catch (System.InvalidOperationException ex)
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
            Save.Filter = "xml files(*.xml)|*.xml";
            Save.FilterIndex = 1;
            if (Save.ShowDialog() == DialogResult.OK)
            {
                fname = Save.FileName;
                NewArr.SaveResult(fname);

            }
        }
    }
}
