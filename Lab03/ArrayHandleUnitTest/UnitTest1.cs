using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab03;

namespace ArrayHandleUnitTest
{
    /// <summary>
    /// Класс модульных тестов
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Тест отвечающий за сортировку массива в обратном порядке
        /// </summary>
        [TestMethod]
        public void Reverse()
        {
            Lab03.Array mas = new Lab03.Array();
            int[] exp = {1,2,3,4,5};
            int[] tmp = {5,4,3,2,1};
            bool res = true;
            mas.arr = tmp;
            mas.ReverseArray();
            for (int i = 0; i < 5; i++)
            {
                if (mas.rev_arr[i] != exp[i])
                {
                    res = false;
                    break;
                }
            }
            Assert.AreEqual(true, res);
        }
        /// <summary>
        /// Тест для метода определеия количества простых чисел
        /// </summary>
        [TestMethod]
        public void Simple()
        {
            Lab03.Array mas = new Lab03.Array();
            int exp = 2;
            int[] tmp = { 3,4,0,6,7 };
            mas.arr = tmp;
            mas.SimpleCount();
            int res = mas.num_simple;
            Assert.AreEqual(exp, res);
        }
        /// <summary>
        /// Тест для определения количества чисел с суммой 2-х цыфр кратной 3
        /// </summary>
        [TestMethod]
        public void LastDigitCount()
        {
            Lab03.Array mas = new Lab03.Array();
            int exp = 2;
            int[] tmp = { 45, 12};
            mas.arr = tmp;
            mas.LastDigitSummCount();
            int res = mas.lastdigitcount;
            Assert.AreEqual(exp, res);
        }
        /// <summary>
        /// Тест для определения суммы чисел с суммой 2-х цыфр кратной 3
        /// </summary>
        [TestMethod]
        public void LastDigitSumm()
        {
            Lab03.Array mas = new Lab03.Array();
            int exp = 57;
            int[] tmp = { 45, 12 };
            mas.arr = tmp;
            mas.LastDigitSummCount();
            int res = mas.lastdigitsum;
            Assert.AreEqual(exp, res);
        }
        /// <summary>
        /// Тест метода, формирующего статистику
        /// </summary>
        [TestMethod]
        public void Statistic()
        {
            Lab03.Array mas = new Lab03.Array();
            string exp = "Невозможно разбить на равные подинтервалы!";
            int[] tmp = { 45, 12 };
            mas.maximum = 11;
            mas.minimum = 0;
            mas.RangeStatistic();
            string res = mas.statistic;
            Assert.AreEqual(exp, res);
        }
    }
}
