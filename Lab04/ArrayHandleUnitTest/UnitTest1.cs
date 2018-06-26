using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab04;

namespace ArrayHandleUnitTest
{
    /// <summary>
    /// Класс модульных тестов
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Тест метода, центрирующего массив
        /// </summary>
        [TestMethod]
        public void Centre()
        {
            Matrix mat = new Matrix();
            int[,] tmp = {{2,2},
                          {2,2}};
            double[,] exp = {{0,0},
                            {0,0}};
            mat.mat = tmp;
            mat.sizeSide = 2;
            mat.Centre();
            bool res = true;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (exp[i, j] != mat.centreMatr[i, j])
                        res = false;
                }
            }
            Assert.AreEqual(res, true);
        }
        /// <summary>
        /// Тест для метода определения минимального числа с чётной суммой индексов
        /// </summary>
        [TestMethod]
        public void Least()
        {
            Matrix mat = new Matrix();
            int[,] tmp = {{2,7,5},
                          {-1,-44,3},
                          {12,1,17}};
            mat.mat = tmp;
            mat.sizeSide = 3;
            mat.MinElement();
            Assert.AreEqual(mat.minElem,-44);
        }

        /// <summary>
        /// Тест отвечающий за сортировку матрицы
        /// </summary>
        [TestMethod]
        public void Sort(){
            Matrix mat = new Matrix();
            int[,] tmp = {{3,7,1},
                          {-1,-3,-7},
                          {12,4,16}};
            int[,] exp = {{1,3,7},
                          {-7,-3,-1},
                          {4,12,16}};
            mat.mat = tmp;
            mat.sizeSide = 3;
            mat.SortRows();
            bool res = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (exp[i, j] != mat.sortedMatr[i,j])
                        res = false;
                }
            }
            Assert.AreEqual(res, true);
        }
    }
}
