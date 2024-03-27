using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlavaLab2
{

    public class FixedLengthStringArray
    {

        private string[] array;

        public int Length
        {
            get { return array.Length; }
        }

        public FixedLengthStringArray(int length)
        {
            array = new string[length];
        }

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= array.Length)
                    throw new IndexOutOfRangeException("Індекс виходить за межі діапазону");
                return array[index];
            }
            set
            {
                if (index < 0 || index >= array.Length)
                    throw new IndexOutOfRangeException("Індекс виходить за межі діапазону");
                array[index] = value;
            }
        }

        public FixedLengthStringArray Concat(FixedLengthStringArray other)
        {
            if (array.Length != other.array.Length)
                throw new ArgumentException("Масиви повинні бути однакової довжини");

            FixedLengthStringArray result = new FixedLengthStringArray(array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i] + other[i];
            }
            return result;
        }

        public FixedLengthStringArray MergeUnique(FixedLengthStringArray other)
        {
            if (array.Length != other.array.Length)
                throw new ArgumentException("Масиви повинні бути однакової довжини");

            FixedLengthStringArray result = new FixedLengthStringArray(array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (result[j] == array[i])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    result[i] = array[i];
                }
            }
            return result;
        }

        public void PrintElements()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string element in array)
            {
                sb.AppendLine(element);
            }
            Console.WriteLine("Елементи масиву:");
            Console.WriteLine(sb.ToString());
        }

        public void PrintArray()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Масив:");
            for (int i = 0; i < array.Length; i++)
            {
                sb.AppendLine($"[{i}]: {array[i]}");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
