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
        public IntList()
        {
            array = new int[0];
        }

        public void Add(int value)
        {
            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i += 1)
            {
                newArray[i] = array[i];
            }
            newArray[newArray.Length - 1] = value;
            array = newArray;
        }

        public void Insert(int index, int value)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[index] = value;
            for (int i = 0; i < array.Length; i += 1)
            {
                if (i < index)
                {
                    newArray[i] = array[i];
                }
                else if (i > index - 1)
                {
                    newArray[i + 1] = array[i];
                }
            }
            
            array = newArray;
        }

        public void Remove(int value)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i += 1)
            {
                if (array[i] == value)
                {
                    count +=1;
                }
            }
            int[] newArray = new int[array.Length - count];
            int index = 0;
            for (int i = 0; i < array.Length; i += 1)
            {
                if (array[i] != value)
                {
                    newArray[index] = array[i];
                    index += 1;
                }
            }
            array = newArray;
        }

        public void RemoveAt(int index)
        {
            int[] newArray = new int[array.Length - 1];
            for (int i = 0; i < array.Length; i +=1)
            {
                if (i < index)
                {
                    newArray[i] = array[i];
                }
                else if (i > index)
                {
                    newArray[i - 1] = array[i];
                }
            }
            array = newArray;
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
