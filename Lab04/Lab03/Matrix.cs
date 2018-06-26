using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
namespace Lab04
{
    /// <summary>
    /// Основной класс, реализующий функциональность
    /// </summary>
    [Serializable]
    public class Matrix
    {
        /// <summary>
        /// Основная матрица
        /// </summary>
        private int[,] square_matr;
        /// <summary>
        /// Матрица с отсортированными по возрастанию строками
        /// </summary>
        public int[,] sortedMatr;
        /// <summary>
        /// Отцентрированная матрица
        /// </summary>
        public double[,] centreMatr;
        /// <summary>
        /// Размер одиночного измерения матрицы
        /// </summary>
        public int sizeSide;
        /// <summary>
        /// Верхняя и нижняя граница интервала генерации
        /// </summary>
        public int minimum, maximum;
        /// <summary>
        /// Минимальный елемент с чётной суммой индексов
        /// </summary>
        public int minElem;
        /// <summary>
        /// Свойство для хранения основной матрицы
        /// </summary>
        public int[,] mat
        {
            get
            {
                return square_matr;
            }
            set 
            {
                square_matr = value;
            }
        }
        /// <summary>
        /// Метод генерации матрицы
        /// </summary>
        /// <param name="size">Размер матрицы</param>
        /// <param name="max">Верхний предел генерации</param>
        /// <param name="min"><Нижний предел генерации/param>
        public void Generate(int size,int max,int min)
        {
            maximum = max;
            minimum = min;
            int[,] tmp = new int[size,size];
            DateTime dt = DateTime.Now;
            Random rand = new Random(dt.Millisecond);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    tmp[i,j] = rand.Next(min, max);
                }
            }
            square_matr = tmp;
            sizeSide = size;
        }
        /// <summary>
        /// Метод дл сохранения матрицы в файл
        /// </summary>
        /// <param name="fname">Имя файла</param>
        public void SaveArray(string fname)
        {
            string tmp = "";
            using (FileStream fs = new FileStream(fname, FileMode.Create))
            {
                StreamWriter fileIn = new StreamWriter(fs);
                for (int i = 0; i < sizeSide; i++)
                {
                    for (int j = 0; j < sizeSide; j++)
                    {
                        tmp += square_matr[j, i].ToString() + "*";
                    }
                    fileIn.WriteLine(tmp);
                    tmp = "";
                }
                fileIn.Close();
            }
        }
        /// <summary>
        /// Метод для извлечения матрицы из файла
        /// </summary>
        /// <param name="fname">Имя файла</param>
        public void LoadArray(string fname)
        {
            int[,] tmpMatrix;
            string tmp = "";
            using (FileStream fs = new FileStream(fname, FileMode.Open))
            {
                StreamReader sr = new StreamReader(fs);
                tmp = sr.ReadToEnd();
                
           
            int count = 0;
            for(int i = 0;i<tmp.Length;i++)
            {
                if(tmp[i]=='\n')
                    count++;
            }
            tmpMatrix = new int[count, count];
            int k = 0;
            tmp.Replace("\n","*");
            tmp.Replace("\r", "*");
            for(int i = 0;i<count;i++)
            {
                for(int j = 0;j<count;j++)
                {
                    string numb= "";
                    while (tmp[k]!='*')
                    {
                        numb += tmp[k];
                        k++;
                    }
                    k++;
                    tmpMatrix[j,i] = Convert.ToInt32(numb);
                }
            }
            sr.Close();
            }
            square_matr = tmpMatrix;
            sizeSide = Convert.ToInt32(Math.Sqrt(square_matr.Length));
        }
        /// <summary>
        /// Метод для сохранения результатов обработки в файл
        /// </summary>
        /// <param name="fname">Имя файла</param>
        public void SaveResult(string fname)
        {
            string tmp = "";
            using (FileStream fs = new FileStream(fname, FileMode.Create))
            {
                StreamWriter fileIn = new StreamWriter(fs);
                for (int i = 0; i < sizeSide; i++)
                {
                    for (int j = 0; j < sizeSide; j++)
                    {
                        tmp += square_matr[j, i].ToString() + "*";
                    }
                    fileIn.WriteLine(tmp);
                    tmp = "";
                }
                tmp = "" + minElem.ToString() + "*";
                fileIn.WriteLine(tmp);
                tmp = "";
                for (int i = 0; i < sizeSide; i++)
                {
                    for (int j = 0; j < sizeSide; j++)
                    {
                        tmp += sortedMatr[j,i].ToString() + "*";
                    }
                    fileIn.WriteLine(tmp);
                    tmp = "";
                }
                 tmp = "";
                for (int i = 0; i < sizeSide; i++)
                {
                    for (int j = 0; j < sizeSide; j++)
                    {
                        tmp += centreMatr[j,i].ToString("F4") + "*";
                    }
                    fileIn.WriteLine(tmp);
                    tmp = "";
                }
                fileIn.Close();
            }
 
        }
        /// <summary>
        /// Метод для извлечения из файла результатов обработки
        /// </summary>
        /// <param name="fname">Имя файла</param>
        public void LoadResult(string fname)
        {
           double[,] tmpMatrix;
           string tmp = "";
           string numb = "";
           int k = 0;
           using (FileStream fs = new FileStream(fname, FileMode.Open))
           {
               StreamReader sr = new StreamReader(fs);
               tmp = sr.ReadLine();
               int count = 0;
               for (int i = 0; i < tmp.Length; i++)
               {
                   if (tmp[i] == '*')
                       count++;
               }
               sizeSide = count;
               tmpMatrix = new double[count, count];
               for (int i = 0; i < sizeSide; i++)
               {
                   k = 0;
                   for (int j = 0; j < sizeSide; j++)
                   {
                       
                       numb = "";
                       while (tmp[k] != '*')
                       {
                           numb += tmp[k];
                           k++;
                       }
                       k++;
                       tmpMatrix[j, i] = Convert.ToInt32(numb);
                   }
                   tmp =  sr.ReadLine();
               }
               square_matr = new int[sizeSide, sizeSide];
               for (int i = 0; i < sizeSide; i++)
               {
                   for (int j = 0; j < sizeSide; j++)
                   {
                      square_matr[i,j] = Convert.ToInt32( tmpMatrix[i,j]);
                   }
               }
               k = 0;
               numb = "";
               while (tmp[k] != '*')
               {
                   numb += tmp[k];
                   k++;
               }
               minElem = Convert.ToInt32(numb);
               for (int i = 0; i < sizeSide; i++)
               {
                   tmp = sr.ReadLine();
                   k = 0;
                   for (int j = 0; j < sizeSide; j++)
                   {

                       numb = "";
                       while (tmp[k] != '*')
                       {
                           numb += tmp[k];
                           k++;
                       }
                       k++;
                       tmpMatrix[j, i] = Convert.ToInt32(numb);
                   }
               }
               sortedMatr = new int[sizeSide, sizeSide];
               for (int i = 0; i < sizeSide; i++)
               {
                   for (int j = 0; j < sizeSide; j++)
                   {
                       sortedMatr[i, j] = Convert.ToInt32( tmpMatrix[i, j]);
                   }
               }
               for (int i = 0; i < sizeSide; i++)
               {
                   tmp = sr.ReadLine();
                   k = 0;
                   for (int j = 0; j < sizeSide; j++)
                   {

                       numb = "";
                       tmp.Replace("\n", "*");
                       tmp.Replace("\r", "*");
                       tmp.Replace(",",".");
                       while (tmp[k] != '*')
                       {
                           numb += tmp[k];
                           k++;
                       }
                       k++;
                       tmpMatrix[j, i] = Convert.ToDouble(numb);
                   }
               }
               centreMatr = new double[sizeSide, sizeSide];
               for (int i = 0; i < sizeSide; i++)
               {
                   for (int j = 0; j < sizeSide; j++)
                   {
                       centreMatr[i, j] = tmpMatrix[i, j];
                   }
               }
               sr.Close();
           }
        }
        /// <summary>
        /// Определение мимального элемента с чётной суммой индексов
        /// </summary>
        public void MinElement()
        {
            int minTmp = square_matr[0, 0];
            for (int i = 0; i < sizeSide; i++)
            {
                for (int j = 0; j < sizeSide; j++)
                {
                    if ((i + j) % 2 == 0 && square_matr[i,j]<=minTmp)
                    {
                        minTmp = square_matr[i, j];
                    }
                }
            }
            minElem = minTmp;
        }
        /// <summary>
        /// Метод сортировки матрицы по строкам
        /// </summary>
        public void SortRows()
        {
            int[] tmp = new int[sizeSide];
            sortedMatr = new int[sizeSide,sizeSide];
            for (int i = 0; i < sizeSide; i++)
            {
                for (int j = 0; j < sizeSide; j++)
                {
                    tmp[j] = square_matr[i,j];
                }
                System.Array.Sort(tmp);
                for (int j = 0; j < sizeSide; j++)
                {
                    sortedMatr[i,j] = tmp[j];
                }
            }
        }
        /// <summary>
        /// Метод центрирования матрицы
        /// </summary>
        public void Centre()
        {
            centreMatr = new double[sizeSide, sizeSide];
            double summ = 0;
            for (int i = 0; i < sizeSide; i++)
            {
                for (int j = 0; j < sizeSide; j++)
                {
                    summ += square_matr[i, j];
                }
            }
            summ = summ / (sizeSide * sizeSide);
            for (int i = 0; i < sizeSide; i++)
            {
                for (int j = 0; j < sizeSide; j++)
                {
                    centreMatr[i, j] = Math.Round( square_matr[i, j] - summ,4);
                }
            }
 
        }
       
    }
}
