using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject
{
    //создание класса
    class IntList
    {
        private int[] array;
        private int count;
        //создание конструктора
        public IntList()
        {
            array = new int[5];
            count = 0;
        }
        //количество значений в массиве
        public int Count
        {
            get { return count; }
        }
        //размер массива
        public int Capacity
        {
            get { return array.Length; }
        }

        //функция изменяющая массива размер при необходимости
        private void ResizeIfNeeded()
        {
            if (Count >= Capacity)
            {
                int[] newArray = new int[array.Length * 2];
                for (var i = 0; i < array.Length; i += 1)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
            }
            else if (Capacity - Count > array.Length / 3)
            {
                int[] newArray = new int[array.Length - array.Length / 3];
                for (var i = 0; i < newArray.Length; i += 1)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
            }
        }
        //добавление нового значения в конец
        public void Add(int value)
        {
            ResizeIfNeeded();
            array[Count] = value;
            count += 1;
        }
        //добавление нового значение в указанный индекс
        public void Insert(int index, int value)
        {
            ResizeIfNeeded();
            for (var i = count; i <= count && i > 0; i -= 1)
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
        //поиск минимального значения
        public int Min()
        {
            var min = 0;
            // for (int i = 0; i < array.Length; i += 1)
            //неверно,потому что будет сравнивать и пустые члены массива,где значение 0
            for (var i = 0; i < count - 1; i += 1)
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
        //поиск максимального значения
        public int Max()
        {
            var max = 0;
            //for (int i = 0; i < array.Length; i += 1)
            //чтобы не проходил незаполненные индексы, изменено
            for (var i = 0; i < count - 1; i += 1)
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
        //поиск суммы всех значений
        public int Sum()
        {
            var sum = 0;
            for (var i = 0; i < array.Length; i += 1)
            {
                sum += array[i];
            }
            return sum;
        }
        //получить значение под конкретным индексом
        public int GetValue(int index)
        {
            return array[index];
        }
        //изменить значение под конкретным индексом
        public void SetValue(int index, int value)
        {
            array[index] = value;
        }
        //определить если массив содержит значение
        public bool Contains(int value)
        {
            for (var i = 0; i < array.Length; i += 1)
            {
                if (array[i] == value)
                {
                    return true;
                }
            }
            return false;
        }
        //поиск первого значения
        public int First()
        {
            if (count != 0)
            {
                return array[0];
            }
            return -1;
        }
        //поиск последнего значения
        public int Last()
        {
            if (count != 0)
            {
                return array[count - 1];
            }
            return -1;
        }
        //удаление значения из массива
        public void Remove(int value)
        {
            int countValue = 0;
            for (int i = 0; i < array.Length; i += 1)
            {
                if (array[i] == value)
                {
                    countValue += 1;
                }
            }
            for (int i = 0; i < array.Length; i += 1)
            {
                if (array[i] == value)
                {
                    for (int j = i + 1; j < array.Length; j += 1)
                    {
                        if (array[j] != value)
                        {
                            array[i] = array[j];
                            array[j] = value;
                            break;
                        }
                    }
                }
            }
            count = count - countValue;
            ResizeIfNeeded();
        }
        //удаление значения в индексе
        public void RemoveAt(int index)
        {
            for (var i = 0; i < array.Length - 1; i += 1)
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
            count += 1;
            ResizeIfNeeded();
        }
        //удаление всех значений
        public void RemoveAll()
        {
            for (var i = 0; i < array.Length; i += 1)
            {
                if (array[i] != 0)
                {
                    array[i] = 0;
                }
            }
            ResizeIfNeeded();
        }
        //Сортировка массива
        public void Sort()
        {
            var index = 0;
            for (var j = 0; j < count; j += 1)
            {
                var k = 0;
                var min = int.MaxValue;
                for (var i = index; i < count; i += 1)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                        k = i;
                    }
                }
                array[k] = array[index];
                array[index] = min;
                index += 1;
            }
        }
        //фильтровка массива
        public IntList Filter(Func<int, bool> condition)
        {
            var result = new IntList();
            for (var i = 0; i < array.Length; i += 1)
            {
                if (condition(array[i]))
                {
                    result.Add(array[i]);
                }
            }
            return result;
        }
        //поиск индекса данного значения
        public int IndexOf(Func<int, bool> condition)
        {
            for (var i = 0; i < array.Length; i += 1)
            {
                if (condition(array[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        /*
        public int IndexOf(value)
        {
            return IndexOf(x => x == value);
        }
        */
        //реверс массива
        public void Reverse()
        {
            int[] newArray = new int[array.Length];
            for (var i = 0; i < array.Length; i += 1)
            {
                newArray[array.Length - i - 1] = array[i];
            }
            array = newArray;
        }
        //трансфрормация массива
        public IntList Transform(Func<int, int> transform)
        {
            var result = new IntList();
            for (var i = 0; i < array.Length; i += 1)
            {
                var newValue = transform(array[i]);
                result.Add(newValue);
            }
            return result;
        }
        //пузырьковая сортирка
        public void BubbleSort()
        {
            var temp = 0;
            for (int i = 0; i < Count - 1; i += 1)
            {
                for (int j = 0; j < Count - i - 1; j += 1)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }

                }
            }
        }
    }
}
