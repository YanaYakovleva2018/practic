using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
namespace Lab03
{
    /// <summary>
    /// Основной класс, реализующий функциональность
    /// </summary>
    [Serializable]
    public class Array
    {
        /// <summary>
        /// Основной массив
        /// </summary>
        private int[] mass;
        /// <summary>
        /// Массив в обратном порядке
        /// </summary>
        private int[] rev_mass;
        /// <summary>
        /// Количество простых чисел в массиве
        /// </summary>
        public int num_simple=0;
        /// <summary>
        /// Количество чисел в которых сумма 2-х последних цыфр кратна 3
        /// </summary>
        public int lastdigitcount=0;
        /// <summary>
        /// Сумма чисел в которых сумма 2-х последних цыфр кратна 3
        /// </summary>
        public int lastdigitsum=0;
        /// <summary>
        /// Статистика по попаданию чисел массива в интервалы последовательности
        /// </summary>
        public string statistic;
        /// <summary>
        /// Верхняя и нижняя граница интервала генерации
        /// </summary>
        public int minimum, maximum;
        /// <summary>
        /// Свойство для хранения основного массива
        /// </summary>
        public int[] arr
        {
            get
            {
                return mass;
            }
            set 
            {
                mass = value;
            }
        }
        /// <summary>
        /// Свойство для хранения массива, отсортированного по убыванию
        /// </summary>
         public int[] rev_arr
        {
            get
            {
                return rev_mass;
            }
            set 
            {
                rev_mass = value;
            }
        }
        /// <summary>
        /// Метод генерации массива
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <param name="max">Верхний предел генерации</param>
        /// <param name="min"><Нижний предел генерации/param>
        public void Generate(int size,int max,int min)
        {
            maximum = max;
            minimum = min;
            int[] tmp = new int[size];
            DateTime dt = DateTime.Now;
            Random rand = new Random(dt.Millisecond);
            for(int i=0;i<size;i++)
            {
                tmp[i] = rand.Next(min,max);
            }
            mass = tmp;
        }
        /// <summary>
        /// Метод дл сохранения массива в файл
        /// </summary>
        /// <param name="fname">Имя файла</param>
        public void SaveArray(string fname)
        {
            SerArray tmp = new SerArray();
            tmp.Value = mass;
            tmp.max = maximum;
            tmp.min = minimum;
            XmlSerializer xmlForm = new XmlSerializer(typeof(SerArray));
            using (FileStream fs = new FileStream(fname, FileMode.Create))
            {
                xmlForm.Serialize(fs,tmp);
            }
        }
        /// <summary>
        /// Метод для извлечения массива из файла
        /// </summary>
        /// <param name="fname">Имя файла</param>
        public void LoadArray(string fname)
        {
            SerArray tmp = new SerArray();
            XmlSerializer xmlForm = new XmlSerializer(typeof(SerArray));
            using (FileStream fs = new FileStream(fname, FileMode.Open))
            {
                tmp =  (SerArray)xmlForm.Deserialize(fs);
            }
            mass = tmp.Value;
            minimum = tmp.min;
            maximum = tmp.max;
        }
        /// <summary>
        /// Метод для сохранения результатов обработки в файл
        /// </summary>
        /// <param name="fname">Имя файла</param>
        public void SaveResult(string fname)
        {
            Array tmp = new Array();
            tmp.mass = arr;
            tmp.maximum = maximum;
            tmp.minimum = minimum;
            tmp.num_simple = num_simple;
            tmp.rev_mass = rev_arr;
            tmp.statistic = statistic;
            tmp.lastdigitsum = lastdigitsum;
            tmp.lastdigitcount = lastdigitcount;
            XmlSerializer xmlForm = new XmlSerializer(typeof(Array));
            using (FileStream fs = new FileStream(fname, FileMode.Create))
            {
                xmlForm.Serialize(fs, tmp);
            }
 
        }
        /// <summary>
        /// Метод для извлечения из файла результатов обработки
        /// </summary>
        /// <param name="fname">Имя файла</param>
        public void LoadResult(string fname)
        {
            Array tmp = new Array();
            XmlSerializer xmlForm = new XmlSerializer(typeof(Array));
            using (FileStream fs = new FileStream(fname, FileMode.Open))
            {
                tmp = (Array)xmlForm.Deserialize(fs);
            }
            arr = tmp.mass;
            maximum = tmp.maximum;
            minimum = tmp.minimum;
            num_simple = tmp.num_simple;
            rev_arr = tmp.rev_mass;
            statistic = tmp.statistic;
            lastdigitsum = tmp.lastdigitsum;
            lastdigitcount = tmp.lastdigitcount;
        }
        /// <summary>
        /// Метод для сортровки массива в обратном порядке
        /// </summary>
        public void ReverseArray()
        {
            rev_mass = new int[mass.Length];
            mass.CopyTo(rev_mass,0);
            System.Array.Sort(rev_mass);
            rev_mass.Reverse();
        }
        /// <summary>
        /// Метод для определения чисел в которых сумма 2-х последних цыфр кратна 3
        /// </summary>
        public void LastDigitSummCount()
        {
            int sum=0, num=0;
            for (int i = 0; i < mass.Length; i++)
            {
                int tmp1, tmp2 = mass[i] % 10;
                tmp1 = mass[i] / 10;
                tmp2 += tmp1 % 10;
                if(tmp2%3==0)
                {
                    num++;
                    sum+=mass[i];
                }
            }
            lastdigitsum = sum;
            lastdigitcount = num;
        }
        /// <summary>
        /// Метод для определения количества простых чисел
        /// </summary>
        public void SimpleCount()
        {
            int tmp = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] <= 1)
                    continue;
                if (mass[i] == 2 || mass[i]==3)
                {
                    tmp++;
                    continue;
                }
                if(IsSimple(mass[i]))
                {
                    tmp++;
                }
            }
            num_simple= tmp;
        }
        /// <summary>
        /// Метод для определения простоты числа
        /// </summary>
        /// <param name="number">Тестируемое число</param>
        /// <returns>Результат теста</returns>
        public bool IsSimple(int number)
        {
            if (number % 2 == 0)
            {
                return false;
            }
            for (int j = 3; j < number / 2; j += 2)
            {
                if (number % j == 0)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Метод для определения статистики попадания чисел в интервалы по границам генерации
        /// </summary>
        public void RangeStatistic()
        {
            int range = maximum - minimum;
            if (IsSimple(range))
            {
                statistic = "Невозможно разбить на равные подинтервалы!";
                return;
            }
            int K = 2;
            string tmp = "";
            for (int i = 2; i < range / 2; i++)
            {
                if (range % i == 0)
                    K = i;
            }
            for (int i = minimum; i < maximum; i += K)
            {
                double count = 0;
                for(int j = 0; j<mass.Length;j++)
                {
                    if (mass[j] >= i && mass[j] < (i + K))
                    {
                        count++;
                    }
                }
                tmp += "Интервал:" + i.ToString("F2") + " - " + (i + K).ToString();
                tmp += ": " + count.ToString("F2") + " чисел(а), ";
                tmp += (count / mass.Length*100).ToString("F2") + "% \n";
            }
            statistic = tmp;
        }
    }
}
