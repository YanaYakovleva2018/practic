using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab03
{
    /// <summary>
    /// Класс, для сериализации отдельно массива и заданных для него границ
    /// </summary>
    [Serializable]
    public class SerArray
    {
        /// <summary>
        /// Поле с основным массивом
        /// </summary>
        public int[] Value;
        /// <summary>
        /// Нижняя граница массива
        /// </summary>
        public int min;
        /// <summary>
        /// Верхняя граница массива
        /// </summary>
        public int max;
    }
}
