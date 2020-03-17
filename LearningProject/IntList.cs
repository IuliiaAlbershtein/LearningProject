using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject
{
    class IntList
    {
        private int[] array;
        private int count;
        public IntList()
        {
            array = new int[5];
            count = 0;
        }
        private void ResizeIfNeeded()
        {
            if (GetCount() >= GetCapacity())
            {
                int[] newArray = new int[array.Length * 2];
                for (int i = 0; i < array.Length; i += 1)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
            }
            else if (GetCapacity() - GetCount() > array.Length / 3 )
            {
                int[] newArray = new int[array.Length - array.Length / 3];
                for (int i = 0; i < newArray.Length; i += 1)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
            }
        }
        public void Add(int value)
        {
            ResizeIfNeeded();
            array[GetCount()] = value;
            count += 1;
        }

        public void Insert(int index, int value)
        {
            ResizeIfNeeded();
            for (int i = count; i <= count && i > 0; i -= 1)
            {
                if (i == count)
                {
                    array[count] = array[count - 1];
                }
                else if (i < count && i > index)
                {
                    array[i] = array[i - 1];
                }
                else if (i == index)
                {
                    array[i] = value;
                }
            }
            count += 1;
        }

        public void Remove(int value)
        {
            for (int i = 0; i < array.Length - 1; i += 1)
            {
                if (array[i] == value)
                {
                    array[i] = array[i + 1];
                }
            }
            count -= 1;
            ResizeIfNeeded();
        }

        public void RemoveAt(int index)
        {
            for (int i = 0; i < array.Length - 1; i +=1)
            {
                if (i == index)
                {
                    array[i] = array[i + 1];
                }
                else if (i > index)
                {
                    array[i] = array[i + 1];
                }
            }
            count -= 1;
            ResizeIfNeeded();
        }
        public void RemoveAll()
        {
            // int[] newArray = new int[5];
            // array = newArray;
            for (int i = 0; i < array.Length; i += 1)
            {
                if (array[i] != 0)
                {
                    array[i] = 0;
                }
            }
            ResizeIfNeeded();
        }
        public int IndexOf(int value)
        {
            for (int i = 0; i < array.Length; i += 1)
            {
                if (array[i] == value)
                {
                return i;
                }
            }
            return -1;
        }
        public void Reverse()
        {
            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length; i += 1)
            {
                newArray[array.Length - i - 1] = array[i];
            }
            array = newArray;
        }

        public int GetCount()
        {
            return count;
        }

        public int GetCapacity()
        {
            return array.Length;
        }

        public int GetValue(int index)
        {
            return array[index];
        }

        public void SetValue(int index, int value)
        {
            array[index] = value;
        }
        public bool Contains(int value)
        {
            for (int i = 0; i < array.Length; i += 1)
            {
                if (array[i] == value)
                {
                    return true;
                }
            }
            return false;
        }
        public int Max()
        {
            int max = 0;
            for (int i = 0; i < array.Length; i += 1)
            {
                if (i == 0)
                {
                    max = array[i];
                    continue;
                }

                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        public int Min()
        {
            int min = 0;
            for (int i = 0; i < array.Length; i += 1)
            {
                if (i == 0)
                {
                    min = array[i];
                    continue;
                }

                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i += 1)
            {
                sum += array[i];
            }
            return sum;
        }

    }
}
